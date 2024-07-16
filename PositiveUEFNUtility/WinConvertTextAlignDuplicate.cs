using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace PositiveUEFNUtility
{
    public partial class WinConvertTextAlignDuplicate : Form
    {
        // 複数行のテキストをstringに設定
        private const string templateText = @"
Begin Map
   Begin Level
{Actors}
   End Level
Begin Surface
End Surface
End Map
";

        public WinConvertTextAlignDuplicate()
        {
            InitializeComponent();
        }

        private void buttonConvertAlignText_Click(object sender, EventArgs e)
        {
            string[] srcLines = textBoxSrcText.Lines;

            string actorText = getActorBlockText(srcLines);

            Vector3 startPosition = new Vector3(
                (float)numericUpDownStartPositionX.Value,
                (float)numericUpDownStartPositionY.Value,
                (float)numericUpDownStartPositionZ.Value);

            Vector3 offset = new Vector3(
                (float)numericUpDownAlignXOffset.Value,
                (float)numericUpDownAlignYOffset.Value,
                (float)numericUpDownAlignZOffset.Value);

            List<string> alignText = alignActorText(
                actorText,
                startPosition,
                (int)numericUpDownAlignXCount.Value,
                (int)numericUpDownAlignYCount.Value,
                (int)numericUpDownAlignZCount.Value,
                offset);

            string actorBlocks = string.Join(Environment.NewLine, alignText);

            string convertText = templateText.Replace("{Actors}", actorBlocks);

            // 空行を削除する
            textBoxDstText.Text = Regex.Replace(convertText, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).Trim();
        }

        private List<string> alignActorText(string text, Vector3 startPosition, int xCount, int yCount, int zCount, Vector3 offset)
        {
            List<string> alignText = new List<string>();
            int count = 1;
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 0; j < yCount; j++)
                {
                    for (int k = 0; k < zCount; k++)
                    {
                        Vector3 position = getConvertPosition(startPosition, i, j, k, offset);
                        string actorText = replaceRelativeLocation(text, count, position.X, position.Y, position.Z);
                        alignText.Add(actorText);
                        count++;
                    }
                }
            }

            return alignText;
        }

        private Vector3 getConvertPosition(Vector3 startPosition, int x, int y, int z, Vector3 offset)
        {
            return new Vector3(
                startPosition.X + x * offset.X,
                startPosition.Y + y * offset.Y,
                startPosition.Z + z * offset.Z
            );
        }

        public static string replaceRelativeLocation(string text, int count, float newX, float newY, float newZ)
        {
            // 正規表現パターン
            string pattern = @"RelativeLocation=\(X=([\-0-9\.]+),Y=([\-0-9\.]+),Z=([\-0-9\.]+)\)";

            // 置き換え文字列
            string replacement = $"RelativeLocation=(X={newX},Y={newY},Z={newZ})";

            string tmp = Regex.Replace(text, pattern, replacement);

            pattern = @"(ActorLabel=""[^""]+)""";
            
            // 正規表現による置換処理
            return Regex.Replace(tmp, pattern, m => $"{m.Groups[1].Value}{count}\"");
        }

        private string getActorBlockText(string[] lines)
        {
            List<string> actorLines = new List<string>();

            bool isActorBlock = false;

            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("Begin Actor"))
                {
                    isActorBlock = true;
                }

                if (isActorBlock)
                {
                    actorLines.Add(line);
                }

                if (line.Trim().StartsWith("End Actor"))
                {
                    isActorBlock = false;
                }
            }

            return string.Join(Environment.NewLine, actorLines);
        }
    }
}

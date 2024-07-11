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

namespace PositiveUEFNUtility
{
    public partial class WinGetOutlinerActorLabel : Form
    {
        public WinGetOutlinerActorLabel()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if(textBoxSrcText.Text == string.Empty)
                return;

            // テキスト情報からActorLabel一覧に変換する
            convertActorLables(textBoxSrcText.Text);
        }

        private void buttonConvertClipboard_Click(object sender, EventArgs e)
        {
            // クリップボードからテキストを取得
            string clipboardText = Clipboard.GetText();

            if (clipboardText == string.Empty)
                return;

            // クリップボードのテキスト情報をTextBoxに設定する
            textBoxSrcText.Text = clipboardText;

            // テキスト情報からActorLabel一覧に変換する
            convertActorLables(textBoxSrcText.Text);

            // 変更したテキストをクリップボードに貼り付け
            Clipboard.SetText(textBoxDestText.Text);
        }

        private void convertActorLables(string text)
        {
            // Actor Labelをリストに格納する
            List<string> actorLabels = extractActorLabels(textBoxSrcText.Text);

            // リストの情報を1行ずつの文字列に変換する
            textBoxDestText.Text = string.Join(Environment.NewLine, actorLabels);
        }

        private List<string> extractActorLabels(string text)
        {
            string pattern = @"ActorLabel=""([^""]+)""";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(textBoxSrcText.Text);

            List<string> actorLabels = new List<string>();
            foreach (Match match in matches)
            {
                actorLabels.Add(match.Groups[1].Value);
            }

            // 配列をソート
            actorLabels.Sort();

            return actorLabels;
        }
    }
}

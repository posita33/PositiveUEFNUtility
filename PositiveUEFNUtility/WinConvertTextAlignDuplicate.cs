using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
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

        private int colorIndex = 0;
        private readonly Color[] colors = {
            Color.White,
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Indigo,
            Color.Violet
        };

        public WinConvertTextAlignDuplicate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Windowをロードする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinConvertTextAlignDuplicate_Load(object sender, EventArgs e)
        {
            // 設定を読み込む
            LoadSetting();

            // カラーを設定する
            panelCompleteColor.BackColor = colors[colorIndex];
        }

        /// <summary>
        /// 設定を保存するメニューをクリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSaveSettings_Click(object sender, EventArgs e)
        {
            // 設定を保存する
            SaveSettings();
        }

        /// <summary>
        /// 入力値の設定を保存する
        /// </summary>
        private void SaveSettings()
        {
            Properties.Settings.Default.StartPositionX = numericUpDownStartPositionX.Value;
            Properties.Settings.Default.StartPositionY = numericUpDownStartPositionY.Value;
            Properties.Settings.Default.StartPositionZ = numericUpDownStartPositionZ.Value;

            Properties.Settings.Default.CheckLocationX = checkBoxAlignX.Checked;
            Properties.Settings.Default.LocationXCount = numericUpDownAlignXCount.Value;
            Properties.Settings.Default.LocationXOffsetDistance = numericUpDownAlignXOffsetDistance.Value;
            Properties.Settings.Default.CheckLocationXRondom = checkBoxXLocationRandom.Checked;
            Properties.Settings.Default.LocationXRandomMin = numericUpDownXLocationRandomMin.Value;
            Properties.Settings.Default.LocationXRandomMax = numericUpDownXLocationRandomMax.Value;

            Properties.Settings.Default.CheckLocationY = checkBoxAlignY.Checked;
            Properties.Settings.Default.LocationYCount = numericUpDownAlignYCount.Value;
            Properties.Settings.Default.LocationYOffsetDistance = numericUpDownAlignYOffsetDistance.Value;
            Properties.Settings.Default.CheckLocationYRondom = checkBoxYLocationRandom.Checked;
            Properties.Settings.Default.LocationYRandomMin = numericUpDownYLocationRandomMin.Value;
            Properties.Settings.Default.LocationYRandomMax = numericUpDownYLocationRandomMax.Value;

            Properties.Settings.Default.CheckLocationZ = checkBoxAlignZ.Checked;
            Properties.Settings.Default.LocationZCount = numericUpDownAlignZCount.Value;
            Properties.Settings.Default.LocationZOffsetDistance = numericUpDownAlignZOffsetDistance.Value;
            Properties.Settings.Default.CheckLocationZRondom = checkBoxZLocationRandom.Checked;
            Properties.Settings.Default.LocationZRandomMin = numericUpDownZLocationRandomMin.Value;
            Properties.Settings.Default.LocationZRandomMax = numericUpDownZLocationRandomMax.Value;

            Properties.Settings.Default.AlignDuplicateClipboardCopy = checkBoxCopyClipboard.Checked;

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 設定を読み込む
        /// </summary>
        private void LoadSetting()
        {
            numericUpDownStartPositionX.Value = Properties.Settings.Default.StartPositionX;
            numericUpDownStartPositionY.Value = Properties.Settings.Default.StartPositionY;
            numericUpDownStartPositionZ.Value = Properties.Settings.Default.StartPositionZ;

            checkBoxAlignX.Checked = Properties.Settings.Default.CheckLocationX;
            numericUpDownAlignXCount.Value = Properties.Settings.Default.LocationXCount;
            numericUpDownAlignXOffsetDistance.Value = Properties.Settings.Default.LocationXOffsetDistance;
            checkBoxXLocationRandom.Checked = Properties.Settings.Default.CheckLocationXRondom;
            numericUpDownXLocationRandomMin.Value = Properties.Settings.Default.LocationXRandomMin;
            numericUpDownXLocationRandomMax.Value = Properties.Settings.Default.LocationXRandomMax;

            checkBoxAlignY.Checked = Properties.Settings.Default.CheckLocationY;
            numericUpDownAlignYCount.Value = Properties.Settings.Default.LocationYCount;
            numericUpDownAlignYOffsetDistance.Value = Properties.Settings.Default.LocationYOffsetDistance;
            checkBoxYLocationRandom.Checked = Properties.Settings.Default.CheckLocationYRondom;
            numericUpDownYLocationRandomMin.Value = Properties.Settings.Default.LocationYRandomMin;
            numericUpDownYLocationRandomMax.Value = Properties.Settings.Default.LocationYRandomMax;

            checkBoxAlignZ.Checked = Properties.Settings.Default.CheckLocationZ;
            numericUpDownAlignZCount.Value = Properties.Settings.Default.LocationZCount;
            numericUpDownAlignZOffsetDistance.Value = Properties.Settings.Default.LocationZOffsetDistance;
            checkBoxZLocationRandom.Checked = Properties.Settings.Default.CheckLocationZRondom;
            numericUpDownZLocationRandomMin.Value = Properties.Settings.Default.LocationZRandomMin;
            numericUpDownZLocationRandomMax.Value = Properties.Settings.Default.LocationZRandomMax;

            checkBoxCopyClipboard.Checked = Properties.Settings.Default.AlignDuplicateClipboardCopy;
        }

        /// <summary>
        /// 使い方のForumページを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemDocument_Click(object sender, EventArgs e)
        {
            string url = "https://dev.epicgames.com/community/learning/tutorials/vw41/fortnite-positive-uefn-utility";
            PositiveUtility.OpenUrl(url);
        }

        /// <summary>
        /// Discordの招待URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemDiscord_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/WHv8egZnhy";
            PositiveUtility.OpenUrl(url);
        }

        /// <summary>
        /// 「変換」ボタンをクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvertAlignText_Click(object sender, EventArgs e)
        {

            // ツールを実行するのに必要な情報が含まれているかチェックする
            if (!ContainsDesiredInformation(textBoxSrcText.Text))
            {
                MessageBox.Show("テキスト内に変換できるための情報が含まれていません。");
                return;
            }

            textBoxDstText.Text = "";

            // テキストを一行ずつの配列に変換する
            string[] srcLines = textBoxSrcText.Lines;

            // Actor一つ分の情報を取得する
            string actorText = getActorBlockText(srcLines);

            // チェックボックスがOFFの時の値をデフォルト値に設定する
            int countX = 1;
            float offsetX = 0;
            int countY = 1;
            float offsetY = 0;
            int countZ = 1;
            float offsetZ = 0;

            if (checkBoxAlignX.Checked)
            {
                countX = (int)numericUpDownAlignXCount.Value;
                offsetX = (float)numericUpDownAlignXOffsetDistance.Value;
            }

            if (checkBoxAlignY.Checked)
            {
                countY = (int)numericUpDownAlignYCount.Value;
                offsetY = (int)numericUpDownAlignYOffsetDistance.Value;
            }

            if (checkBoxAlignZ.Checked)
            {
                countZ = (int)numericUpDownAlignZCount.Value;
                offsetZ = (float)numericUpDownAlignZOffsetDistance.Value;
            }

            Vector3 startPosition = new Vector3(
                (float)numericUpDownStartPositionX.Value,
                (float)numericUpDownStartPositionY.Value,
                (float)numericUpDownStartPositionZ.Value);

            Vector3 offsetDistance = new Vector3(offsetX,offsetY,offsetZ);

            // 整列するためのActor情報をリストに追加する
            List<string> alignText = alignActorText(
                actorText,
                startPosition,
                countX,
                countY,
                countZ,
                offsetDistance);

            // ActorのBlockを文字列に変換します
            string actorBlocks = string.Join(Environment.NewLine, alignText);

            // テンプレートに複製したActor情報を置換する
            string convertText = templateText.Replace("{Actors}", actorBlocks);

            // 空行を削除する
            textBoxDstText.Text = Regex.Replace(convertText, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).Trim();

            // Clipboardに変換結果をコピーするか
            if (checkBoxCopyClipboard.Checked)
            {
                // 変更したテキストをクリップボードに貼り付け
                Clipboard.SetText(textBoxDstText.Text);
            }

            // 次の色にインデックスを進める
            colorIndex = (colorIndex + 1) % colors.Length;
            // ボタンの背景色を変更
            panelCompleteColor.BackColor = colors[colorIndex];
        }

        /// <summary>
        /// 変換する文字列が含まれているか確認する
        /// </summary>
        /// <param name="text"></param>
        /// <returns>変換する文字列が含まれている：true, 変換する文字が含まれていない:false</returns>
        private bool ContainsDesiredInformation(string text)
        {
            bool result1 = text.Contains("Begin Actor");
            bool result2 = text.Contains("End Actor");
            bool result3 = text.Contains("RelativeLocation=");

            return result1 & result2 & result3;
        }

        /// <summary>
        /// 整列するActorのテキストを変換する
        /// </summary>
        /// <param name="text">文字列</param>
        /// <param name="startPosition">開始位置</param>
        /// <param name="xCount">Xのカウント</param>
        /// <param name="yCount">Yのカウント</param>
        /// <param name="zCount">Zのカウント</param>
        /// <param name="offsetDistance">オフセット距離</param>
        /// <returns>Actor情報のBlock情報のリスト</returns>
        private List<string> alignActorText(string text, Vector3 startPosition, int xCount, int yCount, int zCount, Vector3 offsetDistance)
        {
            List<string> alignText = new List<string>();
            Random r = new Random(GetSeedFromCurrentTime());
            int count = 1;
            for (int i = 0; i < xCount; i++)
            {
                for (int j = 0; j < yCount; j++)
                {
                    for (int k = 0; k < zCount; k++)
                    {
                        Vector3 position = getConvertPosition(r, startPosition, i, j, k, offsetDistance);
                        string actorText = replaceRelativeLocation(text, count, position.X, position.Y, position.Z);
                        alignText.Add(actorText);
                        count++;
                    }
                }
            }

            return alignText;
        }

        /// <summary>
        /// 変換する位置情報を取得する
        /// </summary>
        /// <param name="startPosition">開始位置</param>
        /// <param name="x">Xのカウント</param>
        /// <param name="y">Yのカウント</param>
        /// <param name="z">Zのカウント</param>
        /// <param name="offsetDistance">オフセット距離</param>
        /// <returns>変換する位置情報</returns>
        private Vector3 getConvertPosition(Random r, Vector3 startPosition, int x, int y, int z, Vector3 offsetDistance)
        {

            float randomX = 0.0f;
            float randowY = 0.0f;
            float randomZ = 0.0f;

            if (checkBoxXLocationRandom.Checked)
            {
                randomX = generateRandomFloatInRange(
                    r,
                    (float)numericUpDownXLocationRandomMin.Value,
                    (float)numericUpDownXLocationRandomMax.Value);
            }

            if (checkBoxYLocationRandom.Checked)
            {
                randowY = generateRandomFloatInRange(
                    r,
                    (float)numericUpDownYLocationRandomMin.Value,
                    (float)numericUpDownYLocationRandomMax.Value);

            }

            if (checkBoxZLocationRandom.Checked)
            {
                randomZ = generateRandomFloatInRange(
                    r,
                    (float)numericUpDownZLocationRandomMin.Value,
                    (float)numericUpDownZLocationRandomMax.Value);
            }

            // 変換する位置情報
            return new Vector3(
                startPosition.X + x * offsetDistance.X + randomX,
                startPosition.Y + y * offsetDistance.Y + randowY,
                startPosition.Z + z * offsetDistance.Z + randomZ
            );
        }

        /// <summary>
        /// 2つの値からランダムな値を取得する
        /// </summary>
        /// <param name="min">最小値</param>
        /// <param name="max">最大値</param>
        /// <returns>ランダムな値</returns>
        private float generateRandomFloatInRange(Random r, float min, float max)
        {
            if (min > max)
            {
                float temp = min;
                min = max;
                max = temp;
            }
            
            return (float)(r.NextDouble() * (max - min) + min);
        }

        /// <summary>
        /// 時間からシード値を取得する
        /// </summary>
        /// <returns>シード値</returns>
        private int GetSeedFromCurrentTime()
        {
            // 現在の時刻をTicksで取得し、それをintに変換します
            long ticks = DateTime.Now.Ticks;
            return ticks.GetHashCode();
        }

        /// <summary>
        /// ActorブロックからRelativeLocationを変換したText情報を取得する
        /// </summary>
        /// <param name="text">テキスト情報</param>
        /// <param name="count">ActorBlockのカウント</param>
        /// <param name="newX">新しいX位置</param>
        /// <param name="newY">新しいY位置</param>
        /// <param name="newZ">新しいZ位置</param>
        /// <returns>位置とActorLabelを変換したActorBlockテキスト</returns>
        private string replaceRelativeLocation(string text, int count, float newX, float newY, float newZ)
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

        /// <summary>
        /// Actorブロックのテキストを1つだけ取得する
        /// </summary>
        /// <param name="lines">UEFNテキスト情報</param>
        /// <returns>Actorブロックのテキスト</returns>
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
                    break;
                }
            }

            return string.Join(Environment.NewLine, actorLines);
        }
    }
}

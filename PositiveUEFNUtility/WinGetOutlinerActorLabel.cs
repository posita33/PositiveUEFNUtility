using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PositiveUEFNUtility
{
    public partial class WinGetOutlinerActorLabel : Form
    {
        public WinGetOutlinerActorLabel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// UEFNのテキスト情報からActorLableの一覧に変換します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if(textBoxSrcText.Text == string.Empty)
                return;

            // テキスト情報からActorLabel一覧に変換する
            convertActorLables(textBoxSrcText.Text);
        }

        /// <summary>
        /// クリックボードのテキスト情報を変換して、クリップボードにActorLableの一覧を設定します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// UEFNのテキスト情報からActorLabelを一行ずつの文字列に変換します。
        /// </summary>
        /// <param name="text">UEFNのテキスト情報</param>
        private void convertActorLables(string text)
        {
            // Actor Labelをリストに格納する
            List<string> actorLabels = extractActorLabels(textBoxSrcText.Text);

            // リストの情報を1行ずつの文字列に変換する
            textBoxDestText.Text = string.Join(Environment.NewLine, actorLabels);
        }
        
        /// <summary>
        /// テキスト情報からActorLabelの情報を抽出します。
        /// </summary>
        /// <param name="text">UEFNのテキスト情報</param>
        /// <returns>ActorLabelの一覧</returns>
        private List<string> extractActorLabels(string text)
        {
            // 正規表現でActorLable情報が書かれた行を抽出する
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

using System;
using System.Windows.Forms;

namespace PositiveUEFNUtility
{
    public partial class WinMain : Form
    {
        public WinMain()
        {
            InitializeComponent();
        }

        private void WinMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 公式ドキュメントを開くボタンです。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenOfficialDocument_Click(object sender, EventArgs e)
        {
            string url = "https://dev.epicgames.com/documentation/ja-jp/uefn/unreal-editor-for-fortnite-documentation";
            PositiveUtility.OpenUrl(url);
        }

        /// <summary>
        /// フォーラムのラーニングページを開くボタンです。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenForumLeaning_Click(object sender, EventArgs e)
        {
            string url = "https://dev.epicgames.com/community/fortnite/learning?sort_by=first_published_at&source=community";
            PositiveUtility.OpenUrl(url);
        }

        /// <summary>
        /// 「選択しているActorのLabelを取得する」ツールを開きます。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowWinGetOutlinerActorLabel_Click(object sender, EventArgs e)
        {
            WinGetOutlinerActorLabel win = new WinGetOutlinerActorLabel();
            win.Show();
        }

        /// <summary>
        /// 整列したActorを複製する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowWinConvertTextAlignDuplicate_Click(object sender, EventArgs e)
        {
            WinConvertTextAlignDuplicate win = new WinConvertTextAlignDuplicate();
            win.Show();
        }

        private void buttonCSVToVerseStructure_Click(object sender, EventArgs e)
        {
            WinCSVToVerseStructure win = new WinCSVToVerseStructure();
            win.Show();
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
        /// GitHubのリポジトリに移動するボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/posita33/PositiveUEFNUtility";
            PositiveUtility.OpenUrl(url);
        }

        /// <summary>
        /// Discordの招待URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDiscord_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/WHv8egZnhy";
            PositiveUtility.OpenUrl(url);
        }

        /// <summary>
        /// 使い方のForumページを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDocument_Click(object sender, EventArgs e)
        {
            string url = "https://dev.epicgames.com/community/learning/tutorials/vw41/fortnite-positive-uefn-utility";
            PositiveUtility.OpenUrl(url);
        }


    }
}

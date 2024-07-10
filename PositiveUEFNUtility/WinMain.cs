using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void buttonOpenOfficialDocument_Click(object sender, EventArgs e)
        {
            string url = "https://dev.epicgames.com/documentation/ja-jp/uefn/unreal-editor-for-fortnite-documentation";
            PositiveUtility.OpenUrl(url);
        }

        private void buttonOpenForumLeaning_Click(object sender, EventArgs e)
        {
            string url = "https://dev.epicgames.com/community/fortnite/learning?sort_by=first_published_at&source=community";
            PositiveUtility.OpenUrl(url);
        }

        private void buttonShowWinGetOutlinerActorLabel_Click(object sender, EventArgs e)
        {
            WinGetOutlinerActorLabel win = new WinGetOutlinerActorLabel();
            win.Show();
        }
    }
}

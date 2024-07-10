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

            textBoxDestText.Text = string.Join(Environment.NewLine, actorLabels);
        }
    }
}

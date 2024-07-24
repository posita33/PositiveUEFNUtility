using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace PositiveUEFNUtility
{
    public partial class WinCSVToVerseStructure : Form
    {
        private const string TopLineVariableName = "{VariableName}";

        private const string TopLineTemplate = @"    {VariableName} : []Str_TalkTextList = array:";

        private const string ListTemplateSingleVariables = "{SingleVariables}";
        private const string ListTemplateArrayVariables = "{ArrayVariables}";

        private const string ListTemplate = @"
        Str_TalkTextList:
{SingleVariables}
            TextDatas := array:
{ArrayVariables}
";

        private const string ReplaceSingleVariablesNPC_Name = "{NPC_Name}";
        private const string ReplaceSingleVariablesLanguage_Type = "{Language_Type}";
        private const string ReplaceSingleVariablesQuestID = "{QuestID}";
        private const string ReplaceSingleVariablesQuestProgress = "{QuestProgress}";
        private const string ReplaceSingleVariablesPriority = "{Priority}";
        private const string ReplaceSingleVariablesSound_TalkStart = "{Sound_TalkStart}";
        private const string ReplaceSingleVariablesSound_TalkEnd = "{Sound_TalkEnd}";

        private const string SingleVariablesTemplate = @"
            NPC_Name := {NPC_Name}
            Language_Type := {Language_Type}
            TargetQuestProgress := Str_QuestProgress{QuestID := {QuestID}, QuestProgress := {QuestProgress}}
            Priority := {Priority}
            Sound_TalkStart := {Sound_TalkStart}
            Sound_TalkEnd := {Sound_TalkEnd}
";

        private const string ReplaceArrayVariablesTitle_Text = "{Title_Text}";
        private const string ReplaceArrayVariablesQuestID = "{QuestID}";
        private const string ReplaceArrayVariablesQuestProgress = "{QuestProgress}";
        private const string ReplaceArrayVariablesLanguage = "{Language}";
        private const string ReplaceArrayVariablesButton_Text = "{Button_Text}";
        private const string ReplaceArrayVariablesSound_NextPage = "{Sound_NextPage}";

        private const string ArrayVariablesTemplate = @"
                Str_TextData:
                    Title_Text := ""{Title_Text}"",
                    Description_Text := (""QuestID := {QuestID}, QuestProgress := {QuestProgress}, {Language}""),
                    Button_Text := ""{Button_Text}"",
                    Sound_NextPage := {Sound_NextPage}
";

        public WinCSVToVerseStructure()
        {
            InitializeComponent();
        }

        private void WinCSVToVerseStructure_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void saveSettings()
        {
            Properties.Settings.Default.CSVToVerseStructureVariable = textBoxVariables.Text;

            Properties.Settings.Default.Save();
        }

        private void loadSettings()
        {
            textBoxVariables.Text = Properties.Settings.Default.CSVToVerseStructureVariable;
        }

        private void textBoxConvertText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBoxConvertText_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                List<string> lines = new List<string>();

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                    string text = convertCSVFileToVerseStructure(file);

                    if (text != string.Empty)
                    {
                        lines.Add(text);
                    }
                }

                string listText = string.Join(Environment.NewLine, lines);

                listText = "        " + Regex.Replace(listText, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).Trim();

                string topLine = TopLineTemplate;

                if (textBoxVariables.Text != string.Empty)
                {
                    topLine = topLine.Replace(TopLineVariableName, textBoxVariables.Text);
                }

                textBoxConvertText.Text = normalizeLineEndings(topLine + Environment.NewLine + listText);

                // 変更したテキストをクリップボードに貼り付け
                Clipboard.SetText(textBoxConvertText.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("変換に失敗しました。");
            }
        }

        private string convertCSVFileToVerseStructure(string filePath)
        {
            // ファイルの内容を各行ごとにstringの配列に読み込みます
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

            if (lines.Length < 4)
                return "";

            string singleVariablesText = convertSingleVariables(lines[1]);

            List<string> arrayValiables = new List<string>();

            for (int i = 4; i < lines.Length; i++)
            {
                string text = convertArrayVariables(lines[i]);

                if (text != string.Empty)
                {
                    arrayValiables.Add(text);
                }
            }

            string arrayVariablesText = string.Join(Environment.NewLine, arrayValiables);

            string verseText = ListTemplate.Replace(ListTemplateSingleVariables, singleVariablesText);
            verseText = verseText.Replace(ListTemplateArrayVariables, arrayVariablesText);

            return verseText;
        }

        private string convertSingleVariables(string line)
        {
            string text = "";

            string[] variables = line.Split(',');

            if (variables.Length < 7)
            {
                return text;
            }

            text = SingleVariablesTemplate.Replace(ReplaceSingleVariablesNPC_Name, variables[0]);
            text = text.Replace(ReplaceSingleVariablesLanguage_Type, variables[1]);
            text = text.Replace(ReplaceSingleVariablesQuestID, variables[2]);
            text = text.Replace(ReplaceSingleVariablesQuestProgress, variables[3]);
            text = text.Replace(ReplaceSingleVariablesPriority, variables[4]);
            text = text.Replace(ReplaceSingleVariablesSound_TalkStart, variables[5]);
            text = text.Replace(ReplaceSingleVariablesSound_TalkEnd, variables[6]);

            // 空行を削除する
            return "            " + Regex.Replace(text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).Trim();
        }

        private string convertArrayVariables(string line)
        {
            string text = "";

            line = line.Replace(@"\,", "△");

            string[] variables = line.Split(',');

            if (variables.Length < 7)
            {
                return text;
            }

            text = ArrayVariablesTemplate.Replace(ReplaceArrayVariablesTitle_Text, variables[0]);
            text = text.Replace(ReplaceArrayVariablesQuestID, variables[1]);
            text = text.Replace(ReplaceArrayVariablesQuestProgress, variables[2]);
            text = text.Replace(ReplaceArrayVariablesLanguage, variables[3]);
            text = text.Replace(ReplaceArrayVariablesButton_Text, variables[5]);
            text = text.Replace(ReplaceArrayVariablesSound_NextPage, variables[4]);

            text = text.Replace("△", ",");

            // 空行を削除する
            return "                " + Regex.Replace(text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).Trim();
        }

        private string normalizeLineEndings(string input)
        {
            // まず、全てのCRLFをLFに置き換えます
            // これによりCRLFの重複を防ぎます
            string normalized = input.Replace("\r\n", "\n");

            // LFだけをCRLFに置き換えます
            normalized = normalized.Replace("\n", "\r\n");

            return normalized;
        }

        private void ToolStripMenuItemDocument_Click(object sender, EventArgs e)
        {
            string url = "https://dev.epicgames.com/community/learning/tutorials/vw41/fortnite-positive-uefn-utility";
            PositiveUtility.OpenUrl(url);
        }

        private void ToolStripMenuItemDiscord_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/WHv8egZnhy";
            PositiveUtility.OpenUrl(url);
        }

        private void WinCSVToVerseStructure_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KnuckleDownToIt
{
    class BlacklistManager
    {
        readonly List<string> listOfDirtyApps = new List<string>();
        

        private char[] tempArray;
        private string tempString =  "";
        private string blacklistTxt = @"\blacklist.txt";
        private readonly TextBox textBoxUrLtoBlock;
        private readonly ListBox listBoxBlackList;
        private readonly BrowserChecker browserChecker;

        public BlacklistManager(TextBox textBox,
            ListBox listBox)
        {
            textBoxUrLtoBlock = textBox;
            listBoxBlackList = listBox;

            browserChecker = new BrowserChecker(listOfDirtyApps);
        }

        public void StartSafeChrome()
        {
            browserChecker.StartSafeChrome();
        }

        public void DeleteFromList()
        {
            if (listOfDirtyApps.Contains(listBoxBlackList.SelectedItem))
            {
                listOfDirtyApps.Remove(listBoxBlackList.SelectedItem.ToString());
                listBoxBlackList.Items.Remove(listBoxBlackList.SelectedItem);
            }
        }

        public void AddToList()
        {
            if (textBoxUrLtoBlock.Text != null)
            {
                tempArray = textBoxUrLtoBlock.Text.ToCharArray();
                for (int i = 8; i < tempArray.Length; i++)
                {
                    if (tempArray[i] != '/')
                    {
                        tempString += tempArray[i];
                    }
                    else
                    {
                        break;
                    }
                }
                listOfDirtyApps.Add(tempString);
                listBoxBlackList.Items.Add(tempString);
                tempString = "";
                textBoxUrLtoBlock.Text = null;
            }
        }

        public void SaveTheBlacklist()
        {
            if (listBoxBlackList.Items.Count == 0)
            {
                MessageBox.Show("Please enter URLs to block", "Unable to save", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (File.Exists(blacklistTxt))
            {
                DialogResult dialogResult = MessageBox.Show("Blacklist already exists, do you want to replace it?",
                    "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(blacklistTxt);
                    for (int i = 0; i < listOfDirtyApps.Count; i++)
                    {
                        string tempItem = listOfDirtyApps[i];
                        File.AppendAllText(blacklistTxt, tempItem + Environment.NewLine);
                    }
                    MessageBox.Show("New blacklist saved");
                    MessageBox.Show(File.ReadAllText(blacklistTxt));
                }
            }
            else
            {
                for (int i = 0; i < listOfDirtyApps.Count; i++)
                {
                    string tempItem = listOfDirtyApps[i];
                    File.AppendAllText(blacklistTxt, tempItem + Environment.NewLine);
                    MessageBox.Show(File.ReadAllText(blacklistTxt));
                }
                MessageBox.Show("Blacklist saved");
            }
        }

        public void LoadTheBlackList()
        {            
            listBoxBlackList.Items.Clear();
            listOfDirtyApps.Clear();
            listOfDirtyApps.AddRange(File.ReadAllLines(blacklistTxt));
            listBoxBlackList.Items.AddRange(listOfDirtyApps.ToArray());
        }
    }
}


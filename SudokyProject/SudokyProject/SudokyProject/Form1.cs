using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using static SudokyProject.MyServiceUser;
using System.ServiceModel;

namespace SudokyProject
{
    public partial class Form1 : Form
    {

        private ListViewColumnSorter lvwColumnSorter;

        private int _x;
        private int _y;
        public static ServiceHost serviceHost;
        public static ServiceHost serviceHost2;
        public static int hint = 10;
        private int clikcount;

        public Form1()
        {
            InitializeComponent();
            _x = 0;
            _y = 0;
           
            lvwColumnSorter = new ListViewColumnSorter();

            this.playerTable.ListViewItemSorter = lvwColumnSorter;

        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            if (mainMenuBox.Enabled == false)
                Invalidate();    
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            clikcount = 5 + new Random().Next(10);
            mainMenuBox.Visible = false;
            mainMenuBox.Enabled = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (!mainMenuBox.Visible)
            {
                if (picturePlane.Location!=pictureCloud.Location)
                {
                    MessageBox.Show("You won't get a hint","You lose");
                    clikcount = 0;
                    pictureCloud.Location = new Point(_x, _y);
                    picturePlane.Location = pictureCloud.Location;
                    mainMenuBox.Visible = true;
                    mainMenuBox.Enabled = true;
                }
            }
        }

        private void toolStripComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (pickBackgroundtoolStripComboBox.SelectedIndex)
            {
            case 1:
                BackgroundImage = Properties.Resources.сакура;
                break;
            case 2:
                BackgroundImage = Properties.Resources.фон2;
                break;
            case 3:
                BackgroundImage = Properties.Resources.фон3;
                break;
            }
        }

        public void pictureCloud_Click(object sender, EventArgs e)
        {
            if (clikcount >= 1)
            {
                picturePlane.Location = pictureCloud.Location;
                Random rnd = new Random();
                pictureCloud.Location = new Point(rnd.Next(pictureCloud.Size.Width, ActiveForm.Width - pictureCloud.Size.Width), rnd.Next(pictureCloud.Size.Height, ActiveForm.Height - pictureCloud.Size.Height));
                clikcount--;
            }
            else 
                if (!mainMenuBox.Visible)
                {
                    picturePlane.Location = pictureCloud.Location;
                    MessageBox.Show("Got", "You win!");
                    hint++;
                    pictureCloud.Location = new Point(_x, _y);
                    picturePlane.Location = pictureCloud.Location;
                    mainMenuBox.Visible = true;
                    mainMenuBox.Enabled = true;
                }
        } 

        private void amountOfHintsToolSetripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            textBoxHints.Visible = false;
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpPanel.Visible = true;
            playerTable.Visible = false;
            rulesTextBox.Visible = true;
            rulesTextBox.Text = Properties.Resources.Rules.ToString();
        }

        private void getHintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpPanel.Visible = true;
            rulesTextBox.Visible = true;
            rulesTextBox.Text = Properties.Resources.getHints.ToString();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            serviceHost = WorkingWithServer.CreateUserHost();
            serviceHost.Open();

            Hide();
            Form2 newForm = new Form2(hint);
            newForm.ShowDialog();
            newForm = null;
            Show();
            
        }

        private void closeButton4helpPanel_Click(object sender, EventArgs e)
        {
            helpPanel.Visible = false;
            playerTable.Visible = false;
            rulesTextBox.Visible = false;
        }

        private void showRecordsTableButton_Click(object sender, EventArgs e)
        {
            helpPanel.Visible = true;
            playerTable.Visible = true;
            rulesTextBox.Visible = false;

            playerTable.Items.Clear();

            string[] lines = File.ReadAllLines("playerTable.txt");

            ListViewGroup easyLevel = new ListViewGroup("Easy level", HorizontalAlignment.Left);
            ListViewGroup mediumLevel = new ListViewGroup("Middle level", HorizontalAlignment.Left);
            ListViewGroup hardLevel = new ListViewGroup("Hard level", HorizontalAlignment.Left);

            for (int i = 0; i < lines.Length; i += 4)
            {
                ListViewItem Item = new ListViewItem(lines[i + 1]);
                if (lines[i] == "Easy level")
                {
                    Item.Group = easyLevel;
                }
                else
                {
                    if (lines[i] == "Middle level")
                    {
                        Item.Group = mediumLevel;
                    }
                    else
                    {
                        Item.Group = hardLevel;
                    }
                }

                Item.SubItems.Add(lines[i + 2]);
                Item.SubItems.Add(lines[i + 3]);
                playerTable.Items.Add(Item);

            }

            playerTable.Groups.Add(easyLevel);
            playerTable.Groups.Add(mediumLevel);
            playerTable.Groups.Add(hardLevel);

        }

        private void amountOfHintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxHints.Visible = true;
            textBoxHints.Visible = true;
            textBoxHints.Text = hint.ToString();
        }

        private void PickAnotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "Open picture|*.jpg|*.png";
            openFile1.Filter = "JPG Files|*.jpg";

            if (openFile1.ShowDialog() == DialogResult.OK)
                BackgroundImage = new Bitmap(Image.FromFile(openFile1.FileName));
        }

        private void amountOfHintsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            textBoxHints.Visible = false;
        }

        private void aboutTheProgramtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpPanel.Visible = true;
            rulesTextBox.Visible = true;
            rulesTextBox.Text = "Game - Sudoku\n group. 751003, Lizunova Irina\n Teacher Kraskovskiy";
        }

        private void playerTable_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.playerTable.Sort();
        }

        private void playerTable_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.FloralWhite, e.Bounds);
            e.DrawText();
        }

        private void playerTable_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}

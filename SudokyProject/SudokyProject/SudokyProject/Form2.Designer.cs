namespace SudokyProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playGameButton = new System.Windows.Forms.Button();
            this.resetChangesButton = new System.Windows.Forms.Button();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowTheAmountOfTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.getHintButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.theAmountOfHint = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.cancelSavingResultButton = new System.Windows.Forms.Button();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.storeLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.gameLevel = new System.Windows.Forms.TextBox();
            this.playerTime = new System.Windows.Forms.TextBox();
            this.playerStore = new System.Windows.Forms.TextBox();
            this.playerName = new System.Windows.Forms.TextBox();
            this.finishTheGameButton = new System.Windows.Forms.Button();
            this.StopOrRestartTimeButton = new System.Windows.Forms.Button();
            this.upDateResultsButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tablePanel1.BackColor = System.Drawing.Color.Snow;
            this.tablePanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablePanel1.ColumnCount = 9;
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.Location = new System.Drawing.Point(305, 88);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.RowCount = 9;
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanel1.Size = new System.Drawing.Size(427, 373);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.playGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.playGameButton.FlatAppearance.BorderSize = 4;
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGameButton.Location = new System.Drawing.Point(786, 99);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(192, 47);
            this.playGameButton.TabIndex = 1;
            this.playGameButton.Text = "Start";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // resetChangesButton
            // 
            this.resetChangesButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.resetChangesButton.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.resetChangesButton.FlatAppearance.BorderSize = 4;
            this.resetChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetChangesButton.Location = new System.Drawing.Point(786, 164);
            this.resetChangesButton.Name = "resetChangesButton";
            this.resetChangesButton.Size = new System.Drawing.Size(192, 50);
            this.resetChangesButton.TabIndex = 2;
            this.resetChangesButton.Text = "Back";
            this.resetChangesButton.UseVisualStyleBackColor = false;
            this.resetChangesButton.Click += new System.EventHandler(this.resetChangesButton_Click);
            // 
            // levelBox
            // 
            this.levelBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.levelBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.levelBox.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "Easy",
            "Middle",
            "Hard"});
            this.levelBox.Location = new System.Drawing.Point(786, 53);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(192, 29);
            this.levelBox.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(786, 375);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Check";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeStatusLabel,
            this.ShowTheAmountOfTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeStatusLabel
            // 
            this.timeStatusLabel.Name = "timeStatusLabel";
            this.timeStatusLabel.Size = new System.Drawing.Size(95, 17);
            this.timeStatusLabel.Text = "Время решения";
            // 
            // ShowTheAmountOfTime
            // 
            this.ShowTheAmountOfTime.Name = "ShowTheAmountOfTime";
            this.ShowTheAmountOfTime.Size = new System.Drawing.Size(0, 17);
            // 
            // getHintButton
            // 
            this.getHintButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.getHintButton.Enabled = false;
            this.getHintButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.getHintButton.FlatAppearance.BorderSize = 4;
            this.getHintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getHintButton.Location = new System.Drawing.Point(60, 142);
            this.getHintButton.Name = "getHintButton";
            this.getHintButton.Size = new System.Drawing.Size(192, 54);
            this.getHintButton.TabIndex = 7;
            this.getHintButton.Text = "Hint";
            this.getHintButton.UseVisualStyleBackColor = false;
            this.getHintButton.Click += new System.EventHandler(this.getHintButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(978, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 8;
            // 
            // theAmountOfHint
            // 
            this.theAmountOfHint.AutoSize = true;
            this.theAmountOfHint.BackColor = System.Drawing.Color.Khaki;
            this.theAmountOfHint.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theAmountOfHint.Location = new System.Drawing.Point(67, 99);
            this.theAmountOfHint.Name = "theAmountOfHint";
            this.theAmountOfHint.Size = new System.Drawing.Size(40, 18);
            this.theAmountOfHint.TabIndex = 9;
            this.theAmountOfHint.Text = "Stay";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Thistle;
            this.infoPanel.BackgroundImage = global::SudokyProject.Properties.Resources.berries;
            this.infoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.cancelSavingResultButton);
            this.infoPanel.Controls.Add(this.saveResultButton);
            this.infoPanel.Controls.Add(this.levelLabel);
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Controls.Add(this.storeLabel);
            this.infoPanel.Controls.Add(this.playerLabel);
            this.infoPanel.Controls.Add(this.gameLevel);
            this.infoPanel.Controls.Add(this.playerTime);
            this.infoPanel.Controls.Add(this.playerStore);
            this.infoPanel.Controls.Add(this.playerName);
            this.infoPanel.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPanel.Location = new System.Drawing.Point(258, 111);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(522, 295);
            this.infoPanel.TabIndex = 0;
            this.infoPanel.Visible = false;
            // 
            // cancelSavingResultButton
            // 
            this.cancelSavingResultButton.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelSavingResultButton.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.cancelSavingResultButton.FlatAppearance.BorderSize = 4;
            this.cancelSavingResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSavingResultButton.Location = new System.Drawing.Point(366, 185);
            this.cancelSavingResultButton.Name = "cancelSavingResultButton";
            this.cancelSavingResultButton.Size = new System.Drawing.Size(130, 41);
            this.cancelSavingResultButton.TabIndex = 9;
            this.cancelSavingResultButton.Text = "Back";
            this.cancelSavingResultButton.UseVisualStyleBackColor = false;
            this.cancelSavingResultButton.Click += new System.EventHandler(this.cancelSavingResultButton_Click);
            // 
            // saveResultButton
            // 
            this.saveResultButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.saveResultButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.saveResultButton.FlatAppearance.BorderSize = 4;
            this.saveResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveResultButton.Location = new System.Drawing.Point(366, 232);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(130, 41);
            this.saveResultButton.TabIndex = 8;
            this.saveResultButton.Text = "Save";
            this.saveResultButton.UseVisualStyleBackColor = false;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.levelLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.levelLabel.Location = new System.Drawing.Point(258, 205);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(55, 21);
            this.levelLabel.TabIndex = 7;
            this.levelLabel.Text = "Level";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.timeLabel.Location = new System.Drawing.Point(258, 156);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 21);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time";
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.storeLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.storeLabel.Location = new System.Drawing.Point(258, 96);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(55, 21);
            this.storeLabel.TabIndex = 5;
            this.storeLabel.Text = "Score";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playerLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.playerLabel.Location = new System.Drawing.Point(258, 45);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(67, 21);
            this.playerLabel.TabIndex = 4;
            this.playerLabel.Text = "Player";
            // 
            // gameLevel
            // 
            this.gameLevel.Location = new System.Drawing.Point(37, 197);
            this.gameLevel.Name = "gameLevel";
            this.gameLevel.ReadOnly = true;
            this.gameLevel.Size = new System.Drawing.Size(164, 30);
            this.gameLevel.TabIndex = 3;
            // 
            // playerTime
            // 
            this.playerTime.Location = new System.Drawing.Point(37, 148);
            this.playerTime.Name = "playerTime";
            this.playerTime.ReadOnly = true;
            this.playerTime.Size = new System.Drawing.Size(164, 30);
            this.playerTime.TabIndex = 2;
            // 
            // playerStore
            // 
            this.playerStore.Location = new System.Drawing.Point(37, 93);
            this.playerStore.Name = "playerStore";
            this.playerStore.ReadOnly = true;
            this.playerStore.Size = new System.Drawing.Size(164, 30);
            this.playerStore.TabIndex = 1;
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(37, 37);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(164, 30);
            this.playerName.TabIndex = 0;
            // 
            // finishTheGameButton
            // 
            this.finishTheGameButton.BackColor = System.Drawing.Color.MediumOrchid;
            this.finishTheGameButton.Enabled = false;
            this.finishTheGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.finishTheGameButton.FlatAppearance.BorderSize = 4;
            this.finishTheGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishTheGameButton.Location = new System.Drawing.Point(786, 237);
            this.finishTheGameButton.Name = "finishTheGameButton";
            this.finishTheGameButton.Size = new System.Drawing.Size(192, 54);
            this.finishTheGameButton.TabIndex = 10;
            this.finishTheGameButton.Text = "Check and Save";
            this.finishTheGameButton.UseVisualStyleBackColor = false;
            this.finishTheGameButton.Click += new System.EventHandler(this.finishTheGameButton_Click);
            // 
            // StopOrRestartTimeButton
            // 
            this.StopOrRestartTimeButton.BackColor = System.Drawing.Color.LightGreen;
            this.StopOrRestartTimeButton.Enabled = false;
            this.StopOrRestartTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.StopOrRestartTimeButton.FlatAppearance.BorderSize = 4;
            this.StopOrRestartTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopOrRestartTimeButton.Location = new System.Drawing.Point(60, 216);
            this.StopOrRestartTimeButton.Name = "StopOrRestartTimeButton";
            this.StopOrRestartTimeButton.Size = new System.Drawing.Size(192, 50);
            this.StopOrRestartTimeButton.TabIndex = 6;
            this.StopOrRestartTimeButton.Text = "Pause";
            this.StopOrRestartTimeButton.UseVisualStyleBackColor = false;
            this.StopOrRestartTimeButton.Click += new System.EventHandler(this.StopOrRestartTimeButton_Click);
            // 
            // upDateResultsButton
            // 
            this.upDateResultsButton.BackColor = System.Drawing.Color.LightCoral;
            this.upDateResultsButton.Enabled = false;
            this.upDateResultsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.upDateResultsButton.FlatAppearance.BorderSize = 4;
            this.upDateResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upDateResultsButton.Location = new System.Drawing.Point(786, 310);
            this.upDateResultsButton.Name = "upDateResultsButton";
            this.upDateResultsButton.Size = new System.Drawing.Size(192, 54);
            this.upDateResultsButton.TabIndex = 11;
            this.upDateResultsButton.Text = "UpDate Results";
            this.upDateResultsButton.UseVisualStyleBackColor = false;
            this.upDateResultsButton.Click += new System.EventHandler(this.upDateResultsButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SudokyProject.Properties.Resources.сакура;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1073, 548);
            this.Controls.Add(this.upDateResultsButton);
            this.Controls.Add(this.finishTheGameButton);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.theAmountOfHint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getHintButton);
            this.Controls.Add(this.StopOrRestartTimeButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.resetChangesButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.tablePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayGameSudoky";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel1;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button resetChangesButton;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowTheAmountOfTime;
        private System.Windows.Forms.Button getHintButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label theAmountOfHint;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox gameLevel;
        private System.Windows.Forms.TextBox playerTime;
        private System.Windows.Forms.TextBox playerStore;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.Button cancelSavingResultButton;
        private System.Windows.Forms.Button finishTheGameButton;
        private System.Windows.Forms.Button StopOrRestartTimeButton;
        private System.Windows.Forms.Button upDateResultsButton;
    }
}
namespace SudokyProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.featuresOfProgramtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickBackgroundtoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PickAnotherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgramtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuBox = new System.Windows.Forms.GroupBox();
            this.showRecordsTableButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.picturePlane = new System.Windows.Forms.PictureBox();
            this.pictureCloud = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxHints = new System.Windows.Forms.PictureBox();
            this.textBoxHints = new System.Windows.Forms.TextBox();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.playerTable = new System.Windows.Forms.ListView();
            this.columnPlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPlayerStore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlayerTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rulesTextBox = new System.Windows.Forms.RichTextBox();
            this.closeButton4helpPanel = new System.Windows.Forms.Button();
            this.columnPlayerTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.mainMenuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHints)).BeginInit();
            this.helpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featuresOfProgramtoolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutTheProgramtoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // featuresOfProgramtoolStripMenuItem
            // 
            this.featuresOfProgramtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundToolStripMenuItem});
            this.featuresOfProgramtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.featuresOfProgramtoolStripMenuItem.Image = global::SudokyProject.Properties.Resources.фон3;
            this.featuresOfProgramtoolStripMenuItem.Name = "featuresOfProgramtoolStripMenuItem";
            this.featuresOfProgramtoolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.featuresOfProgramtoolStripMenuItem.Text = "Settings";
            // 
            // changeBackgroundToolStripMenuItem
            // 
            this.changeBackgroundToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.changeBackgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickBackgroundtoolStripComboBox,
            this.PickAnotherToolStripMenuItem});
            this.changeBackgroundToolStripMenuItem.Name = "changeBackgroundToolStripMenuItem";
            this.changeBackgroundToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.changeBackgroundToolStripMenuItem.Text = "Change background";
            // 
            // pickBackgroundtoolStripComboBox
            // 
            this.pickBackgroundtoolStripComboBox.BackColor = System.Drawing.Color.Bisque;
            this.pickBackgroundtoolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickBackgroundtoolStripComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickBackgroundtoolStripComboBox.Items.AddRange(new object[] {
            "(нет)",
            "фон1",
            "фон2",
            "фон3"});
            this.pickBackgroundtoolStripComboBox.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.pickBackgroundtoolStripComboBox.Name = "pickBackgroundtoolStripComboBox";
            this.pickBackgroundtoolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.pickBackgroundtoolStripComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripComboBox1_KeyPress);
            // 
            // PickAnotherToolStripMenuItem
            // 
            this.PickAnotherToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.PickAnotherToolStripMenuItem.Name = "PickAnotherToolStripMenuItem";
            this.PickAnotherToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.PickAnotherToolStripMenuItem.Text = "Выбрать другой";
            this.PickAnotherToolStripMenuItem.Click += new System.EventHandler(this.PickAnotherToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesToolStripMenuItem,
            this.getHintsToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(50, 24);
            this.toolStripMenuItem2.Text = "Help";
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.gameRulesToolStripMenuItem.Image = global::SudokyProject.Properties.Resources.о_программе;
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gameRulesToolStripMenuItem.Text = "Instruction for game";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
            // 
            // getHintsToolStripMenuItem
            // 
            this.getHintsToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.getHintsToolStripMenuItem.Image = global::SudokyProject.Properties.Resources.подсказки;
            this.getHintsToolStripMenuItem.Name = "getHintsToolStripMenuItem";
            this.getHintsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.getHintsToolStripMenuItem.Text = "Get hints";
            this.getHintsToolStripMenuItem.Click += new System.EventHandler(this.getHintsToolStripMenuItem_Click);
            // 
            // aboutTheProgramtoolStripMenuItem
            // 
            this.aboutTheProgramtoolStripMenuItem.Name = "aboutTheProgramtoolStripMenuItem";
            this.aboutTheProgramtoolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.aboutTheProgramtoolStripMenuItem.Text = "About";
            this.aboutTheProgramtoolStripMenuItem.Click += new System.EventHandler(this.aboutTheProgramtoolStripMenuItem_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 1;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainMenuBox
            // 
            this.mainMenuBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainMenuBox.AutoSize = true;
            this.mainMenuBox.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainMenuBox.Controls.Add(this.showRecordsTableButton);
            this.mainMenuBox.Controls.Add(this.startGameButton);
            this.mainMenuBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainMenuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.mainMenuBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainMenuBox.Location = new System.Drawing.Point(304, 98);
            this.mainMenuBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainMenuBox.MaximumSize = new System.Drawing.Size(375, 406);
            this.mainMenuBox.Name = "mainMenuBox";
            this.mainMenuBox.Padding = new System.Windows.Forms.Padding(2);
            this.mainMenuBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainMenuBox.Size = new System.Drawing.Size(229, 327);
            this.mainMenuBox.TabIndex = 1;
            this.mainMenuBox.TabStop = false;
            this.mainMenuBox.Text = "Main menu";
            // 
            // showRecordsTableButton
            // 
            this.showRecordsTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showRecordsTableButton.AutoSize = true;
            this.showRecordsTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showRecordsTableButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.showRecordsTableButton.FlatAppearance.BorderSize = 4;
            this.showRecordsTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRecordsTableButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showRecordsTableButton.Location = new System.Drawing.Point(29, 158);
            this.showRecordsTableButton.Margin = new System.Windows.Forms.Padding(2);
            this.showRecordsTableButton.Name = "showRecordsTableButton";
            this.showRecordsTableButton.Size = new System.Drawing.Size(170, 44);
            this.showRecordsTableButton.TabIndex = 2;
            this.showRecordsTableButton.Text = "Score table";
            this.showRecordsTableButton.UseVisualStyleBackColor = false;
            this.showRecordsTableButton.Click += new System.EventHandler(this.showRecordsTableButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startGameButton.AutoSize = true;
            this.startGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.startGameButton.FlatAppearance.BorderSize = 4;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGameButton.Location = new System.Drawing.Point(29, 92);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startGameButton.Size = new System.Drawing.Size(170, 44);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // picturePlane
            // 
            this.picturePlane.BackColor = System.Drawing.Color.Transparent;
            this.picturePlane.Image = global::SudokyProject.Properties.Resources.Paper_Plane_icon__1_;
            this.picturePlane.Location = new System.Drawing.Point(62, 271);
            this.picturePlane.Margin = new System.Windows.Forms.Padding(2);
            this.picturePlane.Name = "picturePlane";
            this.picturePlane.Size = new System.Drawing.Size(52, 43);
            this.picturePlane.TabIndex = 2;
            this.picturePlane.TabStop = false;
            // 
            // pictureCloud
            // 
            this.pictureCloud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureCloud.BackColor = System.Drawing.Color.Transparent;
            this.pictureCloud.Image = global::SudokyProject.Properties.Resources.облако;
            this.pictureCloud.Location = new System.Drawing.Point(53, 246);
            this.pictureCloud.Margin = new System.Windows.Forms.Padding(2);
            this.pictureCloud.Name = "pictureCloud";
            this.pictureCloud.Size = new System.Drawing.Size(128, 128);
            this.pictureCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCloud.TabIndex = 2;
            this.pictureCloud.TabStop = false;
            this.pictureCloud.Click += new System.EventHandler(this.pictureCloud_Click);
            // 
            // pictureBoxHints
            // 
            this.pictureBoxHints.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHints.Image = global::SudokyProject.Properties.Resources.лупа;
            this.pictureBoxHints.Location = new System.Drawing.Point(700, 34);
            this.pictureBoxHints.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHints.Name = "pictureBoxHints";
            this.pictureBoxHints.Size = new System.Drawing.Size(102, 104);
            this.pictureBoxHints.TabIndex = 3;
            this.pictureBoxHints.TabStop = false;
            this.pictureBoxHints.Visible = false;
            // 
            // textBoxHints
            // 
            this.textBoxHints.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxHints.Enabled = false;
            this.textBoxHints.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHints.Location = new System.Drawing.Point(718, 158);
            this.textBoxHints.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHints.Name = "textBoxHints";
            this.textBoxHints.ReadOnly = true;
            this.textBoxHints.Size = new System.Drawing.Size(76, 27);
            this.textBoxHints.TabIndex = 4;
            this.textBoxHints.Visible = false;
            // 
            // helpPanel
            // 
            this.helpPanel.BackColor = System.Drawing.Color.DarkKhaki;
            this.helpPanel.BackgroundImage = global::SudokyProject.Properties.Resources.сакура;
            this.helpPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helpPanel.Controls.Add(this.playerTable);
            this.helpPanel.Controls.Add(this.rulesTextBox);
            this.helpPanel.Controls.Add(this.closeButton4helpPanel);
            this.helpPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.helpPanel.Location = new System.Drawing.Point(185, 51);
            this.helpPanel.Margin = new System.Windows.Forms.Padding(2);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(512, 437);
            this.helpPanel.TabIndex = 5;
            this.helpPanel.Visible = false;
            // 
            // playerTable
            // 
            this.playerTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.playerTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPlayerName,
            this.columnPlayerStore,
            this.colPlayerTime});
            this.playerTable.ForeColor = System.Drawing.Color.SaddleBrown;
            this.playerTable.FullRowSelect = true;
            this.playerTable.GridLines = true;
            this.playerTable.Location = new System.Drawing.Point(32, 48);
            this.playerTable.Margin = new System.Windows.Forms.Padding(2);
            this.playerTable.Name = "playerTable";
            this.playerTable.OwnerDraw = true;
            this.playerTable.Size = new System.Drawing.Size(460, 305);
            this.playerTable.TabIndex = 12;
            this.playerTable.UseCompatibleStateImageBehavior = false;
            this.playerTable.View = System.Windows.Forms.View.Details;
            this.playerTable.Visible = false;
            this.playerTable.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.playerTable_ColumnClick);
            this.playerTable.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.playerTable_DrawColumnHeader);
            this.playerTable.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.playerTable_DrawItem);
            // 
            // columnPlayerName
            // 
            this.columnPlayerName.Text = "Player";
            this.columnPlayerName.Width = 162;
            // 
            // columnPlayerStore
            // 
            this.columnPlayerStore.Text = "Score";
            this.columnPlayerStore.Width = 165;
            // 
            // colPlayerTime
            // 
            this.colPlayerTime.Text = "Time";
            this.colPlayerTime.Width = 143;
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.rulesTextBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesTextBox.Location = new System.Drawing.Point(39, 36);
            this.rulesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.ReadOnly = true;
            this.rulesTextBox.Size = new System.Drawing.Size(420, 376);
            this.rulesTextBox.TabIndex = 10;
            this.rulesTextBox.Text = "";
            this.rulesTextBox.Visible = false;
            // 
            // closeButton4helpPanel
            // 
            this.closeButton4helpPanel.BackColor = System.Drawing.Color.SeaShell;
            this.closeButton4helpPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton4helpPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton4helpPanel.ForeColor = System.Drawing.Color.DarkRed;
            this.closeButton4helpPanel.Location = new System.Drawing.Point(470, 2);
            this.closeButton4helpPanel.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton4helpPanel.Name = "closeButton4helpPanel";
            this.closeButton4helpPanel.Size = new System.Drawing.Size(23, 24);
            this.closeButton4helpPanel.TabIndex = 7;
            this.closeButton4helpPanel.Text = "X";
            this.closeButton4helpPanel.UseVisualStyleBackColor = false;
            this.closeButton4helpPanel.Click += new System.EventHandler(this.closeButton4helpPanel_Click);
            // 
            // columnPlayerTime
            // 
            this.columnPlayerTime.Text = "Время";
            this.columnPlayerTime.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::SudokyProject.Properties.Resources.сакура;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 530);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.textBoxHints);
            this.Controls.Add(this.pictureBoxHints);
            this.Controls.Add(this.mainMenuBox);
            this.Controls.Add(this.picturePlane);
            this.Controls.Add(this.pictureCloud);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SudokyGame";
            this.TransparencyKey = System.Drawing.SystemColors.ControlLightLight;
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainMenuBox.ResumeLayout(false);
            this.mainMenuBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHints)).EndInit();
            this.helpPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem featuresOfProgramtoolStripMenuItem;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox pickBackgroundtoolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem PickAnotherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramtoolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button showRecordsTableButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.GroupBox mainMenuBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureCloud;
        private System.Windows.Forms.PictureBox picturePlane;
        private System.Windows.Forms.ToolStripMenuItem getHintsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxHints;
        private System.Windows.Forms.TextBox textBoxHints;
        private System.Windows.Forms.Button closeButton4helpPanel;
        private System.Windows.Forms.RichTextBox rulesTextBox;
        private System.Windows.Forms.ListView playerTable;
        private System.Windows.Forms.ColumnHeader columnPlayerName;
        private System.Windows.Forms.ColumnHeader columnPlayerStore;
        private System.Windows.Forms.ColumnHeader colPlayerTime;
        private System.Windows.Forms.ColumnHeader columnPlayerTime;
        private System.Windows.Forms.Panel helpPanel;
    }
}


namespace Pogo3DSaveEditor
{
    partial class PogoSaveEditor
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
            this.previewInfoBox = new System.Windows.Forms.GroupBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.difficultyInput = new System.Windows.Forms.ComboBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPMEPLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSaveGroup = new System.Windows.Forms.GroupBox();
            this.checkpointLabel = new System.Windows.Forms.Label();
            this.chapterCheckpoint = new System.Windows.Forms.NumericUpDown();
            this.ChapterLabel = new System.Windows.Forms.Label();
            this.quickSave_Chapter = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.GeneralStats = new System.Windows.Forms.TabPage();
            this.ChapterInfo = new System.Windows.Forms.TabPage();
            this.CI_ChapterDataGroup = new System.Windows.Forms.GroupBox();
            this.CI_CD_Completed = new System.Windows.Forms.CheckBox();
            this.CI_CD_Unlocked = new System.Windows.Forms.CheckBox();
            this.CI_ChapterSelect = new System.Windows.Forms.ComboBox();
            this.CI_CS_Label = new System.Windows.Forms.Label();
            this.Tabs_Global = new System.Windows.Forms.TabPage();
            this.previewInfoBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.quickSaveGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chapterCheckpoint)).BeginInit();
            this.tabs.SuspendLayout();
            this.GeneralStats.SuspendLayout();
            this.ChapterInfo.SuspendLayout();
            this.CI_ChapterDataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewInfoBox
            // 
            this.previewInfoBox.Controls.Add(this.difficultyLabel);
            this.previewInfoBox.Controls.Add(this.nameLabel);
            this.previewInfoBox.Controls.Add(this.difficultyInput);
            this.previewInfoBox.Controls.Add(this.nameInput);
            this.previewInfoBox.Location = new System.Drawing.Point(15, 6);
            this.previewInfoBox.Name = "previewInfoBox";
            this.previewInfoBox.Size = new System.Drawing.Size(200, 100);
            this.previewInfoBox.TabIndex = 0;
            this.previewInfoBox.TabStop = false;
            this.previewInfoBox.Text = "Preview Info";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(6, 48);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(47, 13);
            this.difficultyLabel.TabIndex = 3;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // difficultyInput
            // 
            this.difficultyInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyInput.FormattingEnabled = true;
            this.difficultyInput.Items.AddRange(new object[] {
            "Assist",
            "Normal",
            "Hard"});
            this.difficultyInput.Location = new System.Drawing.Point(73, 45);
            this.difficultyInput.Name = "difficultyInput";
            this.difficultyInput.Size = new System.Drawing.Size(121, 21);
            this.difficultyInput.TabIndex = 1;
            this.difficultyInput.SelectedIndexChanged += new System.EventHandler(this.difficultyInput_SelectedIndexChanged);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(73, 19);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(121, 20);
            this.nameInput.TabIndex = 0;
            this.nameInput.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSaveToolStripMenuItem,
            this.saveSaveToolStripMenuItem,
            this.hELPMEPLSToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSaveToolStripMenuItem
            // 
            this.openSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalDataToolStripMenuItem,
            this.fileDataToolStripMenuItem});
            this.openSaveToolStripMenuItem.Name = "openSaveToolStripMenuItem";
            this.openSaveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openSaveToolStripMenuItem.Text = "Open Save";
            // 
            // globalDataToolStripMenuItem
            // 
            this.globalDataToolStripMenuItem.Name = "globalDataToolStripMenuItem";
            this.globalDataToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.globalDataToolStripMenuItem.Text = "Global Data";
            // 
            // fileDataToolStripMenuItem
            // 
            this.fileDataToolStripMenuItem.Name = "fileDataToolStripMenuItem";
            this.fileDataToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fileDataToolStripMenuItem.Text = "File Data";
            this.fileDataToolStripMenuItem.Click += new System.EventHandler(this.fileDataToolStripMenuItem_Click);
            // 
            // saveSaveToolStripMenuItem
            // 
            this.saveSaveToolStripMenuItem.Name = "saveSaveToolStripMenuItem";
            this.saveSaveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.saveSaveToolStripMenuItem.Text = "Save Save";
            this.saveSaveToolStripMenuItem.Click += new System.EventHandler(this.saveSaveToolStripMenuItem_Click);
            // 
            // hELPMEPLSToolStripMenuItem
            // 
            this.hELPMEPLSToolStripMenuItem.Name = "hELPMEPLSToolStripMenuItem";
            this.hELPMEPLSToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.hELPMEPLSToolStripMenuItem.Text = "HELP ME PLS";
            // 
            // quickSaveGroup
            // 
            this.quickSaveGroup.Controls.Add(this.checkpointLabel);
            this.quickSaveGroup.Controls.Add(this.chapterCheckpoint);
            this.quickSaveGroup.Controls.Add(this.ChapterLabel);
            this.quickSaveGroup.Controls.Add(this.quickSave_Chapter);
            this.quickSaveGroup.Location = new System.Drawing.Point(15, 112);
            this.quickSaveGroup.Name = "quickSaveGroup";
            this.quickSaveGroup.Size = new System.Drawing.Size(200, 100);
            this.quickSaveGroup.TabIndex = 2;
            this.quickSaveGroup.TabStop = false;
            this.quickSaveGroup.Text = "Quick Save";
            // 
            // checkpointLabel
            // 
            this.checkpointLabel.AutoSize = true;
            this.checkpointLabel.Location = new System.Drawing.Point(9, 49);
            this.checkpointLabel.Name = "checkpointLabel";
            this.checkpointLabel.Size = new System.Drawing.Size(61, 13);
            this.checkpointLabel.TabIndex = 6;
            this.checkpointLabel.Text = "Checkpoint";
            // 
            // chapterCheckpoint
            // 
            this.chapterCheckpoint.Location = new System.Drawing.Point(73, 47);
            this.chapterCheckpoint.Name = "chapterCheckpoint";
            this.chapterCheckpoint.Size = new System.Drawing.Size(120, 20);
            this.chapterCheckpoint.TabIndex = 5;
            // 
            // ChapterLabel
            // 
            this.ChapterLabel.AutoSize = true;
            this.ChapterLabel.Location = new System.Drawing.Point(9, 22);
            this.ChapterLabel.Name = "ChapterLabel";
            this.ChapterLabel.Size = new System.Drawing.Size(44, 13);
            this.ChapterLabel.TabIndex = 4;
            this.ChapterLabel.Text = "Chapter";
            // 
            // quickSave_Chapter
            // 
            this.quickSave_Chapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quickSave_Chapter.FormattingEnabled = true;
            this.quickSave_Chapter.Items.AddRange(new object[] {
            "Swamp",
            "Fortress",
            "Storm Drain",
            "Yard",
            "Temple",
            "Internet",
            "Docks",
            "Hollow",
            "Skullrock",
            "Delusion",
            "Pit Of Despair",
            "Acropolis"});
            this.quickSave_Chapter.Location = new System.Drawing.Point(73, 19);
            this.quickSave_Chapter.Name = "quickSave_Chapter";
            this.quickSave_Chapter.Size = new System.Drawing.Size(121, 21);
            this.quickSave_Chapter.TabIndex = 0;
            this.quickSave_Chapter.SelectedIndexChanged += new System.EventHandler(this.quickSave_Chapter_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.GeneralStats);
            this.tabs.Controls.Add(this.ChapterInfo);
            this.tabs.Controls.Add(this.Tabs_Global);
            this.tabs.Location = new System.Drawing.Point(12, 28);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(776, 410);
            this.tabs.TabIndex = 5;
            // 
            // GeneralStats
            // 
            this.GeneralStats.Controls.Add(this.previewInfoBox);
            this.GeneralStats.Controls.Add(this.quickSaveGroup);
            this.GeneralStats.Location = new System.Drawing.Point(4, 22);
            this.GeneralStats.Name = "GeneralStats";
            this.GeneralStats.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralStats.Size = new System.Drawing.Size(768, 384);
            this.GeneralStats.TabIndex = 0;
            this.GeneralStats.Text = "General Stats";
            this.GeneralStats.UseVisualStyleBackColor = true;
            // 
            // ChapterInfo
            // 
            this.ChapterInfo.Controls.Add(this.CI_ChapterDataGroup);
            this.ChapterInfo.Location = new System.Drawing.Point(4, 22);
            this.ChapterInfo.Name = "ChapterInfo";
            this.ChapterInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ChapterInfo.Size = new System.Drawing.Size(768, 384);
            this.ChapterInfo.TabIndex = 1;
            this.ChapterInfo.Text = "Chapter Info";
            this.ChapterInfo.UseVisualStyleBackColor = true;
            // 
            // CI_ChapterDataGroup
            // 
            this.CI_ChapterDataGroup.Controls.Add(this.CI_CD_Completed);
            this.CI_ChapterDataGroup.Controls.Add(this.CI_CD_Unlocked);
            this.CI_ChapterDataGroup.Controls.Add(this.CI_ChapterSelect);
            this.CI_ChapterDataGroup.Controls.Add(this.CI_CS_Label);
            this.CI_ChapterDataGroup.Location = new System.Drawing.Point(6, 6);
            this.CI_ChapterDataGroup.Name = "CI_ChapterDataGroup";
            this.CI_ChapterDataGroup.Size = new System.Drawing.Size(294, 173);
            this.CI_ChapterDataGroup.TabIndex = 8;
            this.CI_ChapterDataGroup.TabStop = false;
            this.CI_ChapterDataGroup.Text = "Chapter Data";
            // 
            // CI_CD_Completed
            // 
            this.CI_CD_Completed.AutoSize = true;
            this.CI_CD_Completed.Location = new System.Drawing.Point(133, 55);
            this.CI_CD_Completed.Name = "CI_CD_Completed";
            this.CI_CD_Completed.Size = new System.Drawing.Size(76, 17);
            this.CI_CD_Completed.TabIndex = 9;
            this.CI_CD_Completed.Text = "Completed";
            this.CI_CD_Completed.UseVisualStyleBackColor = true;
            this.CI_CD_Completed.CheckedChanged += new System.EventHandler(this.CI_CD_Completed_CheckedChanged_1);
            // 
            // CI_CD_Unlocked
            // 
            this.CI_CD_Unlocked.AutoSize = true;
            this.CI_CD_Unlocked.Location = new System.Drawing.Point(133, 32);
            this.CI_CD_Unlocked.Name = "CI_CD_Unlocked";
            this.CI_CD_Unlocked.Size = new System.Drawing.Size(72, 17);
            this.CI_CD_Unlocked.TabIndex = 8;
            this.CI_CD_Unlocked.Text = "Unlocked";
            this.CI_CD_Unlocked.UseVisualStyleBackColor = true;
            this.CI_CD_Unlocked.CheckedChanged += new System.EventHandler(this.CI_CD_Unlocked_CheckedChanged_1);
            // 
            // CI_ChapterSelect
            // 
            this.CI_ChapterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CI_ChapterSelect.FormattingEnabled = true;
            this.CI_ChapterSelect.Items.AddRange(new object[] {
            "Swamp",
            "Fortress",
            "Storm Drain",
            "Yard",
            "Temple",
            "Internet",
            "Docks",
            "Hollow",
            "Skullrock",
            "Delusion",
            "Pit Of Despair",
            "Acropolis"});
            this.CI_ChapterSelect.Location = new System.Drawing.Point(6, 30);
            this.CI_ChapterSelect.Name = "CI_ChapterSelect";
            this.CI_ChapterSelect.Size = new System.Drawing.Size(121, 21);
            this.CI_ChapterSelect.TabIndex = 6;
            this.CI_ChapterSelect.SelectedIndexChanged += new System.EventHandler(this.CI_ChapterSelect_SelectedIndexChanged);
            // 
            // CI_CS_Label
            // 
            this.CI_CS_Label.AutoSize = true;
            this.CI_CS_Label.Location = new System.Drawing.Point(3, 14);
            this.CI_CS_Label.Name = "CI_CS_Label";
            this.CI_CS_Label.Size = new System.Drawing.Size(44, 13);
            this.CI_CS_Label.TabIndex = 7;
            this.CI_CS_Label.Text = "Chapter";
            // 
            // Tabs_Global
            // 
            this.Tabs_Global.Location = new System.Drawing.Point(4, 22);
            this.Tabs_Global.Name = "Tabs_Global";
            this.Tabs_Global.Padding = new System.Windows.Forms.Padding(3);
            this.Tabs_Global.Size = new System.Drawing.Size(768, 384);
            this.Tabs_Global.TabIndex = 2;
            this.Tabs_Global.Text = "Global";
            this.Tabs_Global.UseVisualStyleBackColor = true;
            // 
            // PogoSaveEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PogoSaveEditor";
            this.Text = "Pogo3D Save Editor";
            this.previewInfoBox.ResumeLayout(false);
            this.previewInfoBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.quickSaveGroup.ResumeLayout(false);
            this.quickSaveGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chapterCheckpoint)).EndInit();
            this.tabs.ResumeLayout(false);
            this.GeneralStats.ResumeLayout(false);
            this.ChapterInfo.ResumeLayout(false);
            this.CI_ChapterDataGroup.ResumeLayout(false);
            this.CI_ChapterDataGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox previewInfoBox;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPMEPLSToolStripMenuItem;
        private System.Windows.Forms.ComboBox difficultyInput;
        private System.Windows.Forms.ToolStripMenuItem saveSaveToolStripMenuItem;
        private System.Windows.Forms.GroupBox quickSaveGroup;
        private System.Windows.Forms.ComboBox quickSave_Chapter;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ChapterLabel;
        private System.Windows.Forms.Label checkpointLabel;
        private System.Windows.Forms.NumericUpDown chapterCheckpoint;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage GeneralStats;
        private System.Windows.Forms.TabPage ChapterInfo;
        private System.Windows.Forms.TabPage Tabs_Global;
        private System.Windows.Forms.ComboBox CI_ChapterSelect;
        private System.Windows.Forms.GroupBox CI_ChapterDataGroup;
        private System.Windows.Forms.Label CI_CS_Label;
        private System.Windows.Forms.CheckBox CI_CD_Completed;
        private System.Windows.Forms.CheckBox CI_CD_Unlocked;
    }
}


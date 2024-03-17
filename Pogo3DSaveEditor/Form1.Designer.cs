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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tools_info = new System.Windows.Forms.ToolStripLabel();
            this.tools_Chapter = new System.Windows.Forms.ToolStripLabel();
            this.tools_Global = new System.Windows.Forms.ToolStripLabel();
            this.previewInfoBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.quickSaveGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chapterCheckpoint)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewInfoBox
            // 
            this.previewInfoBox.Controls.Add(this.difficultyLabel);
            this.previewInfoBox.Controls.Add(this.nameLabel);
            this.previewInfoBox.Controls.Add(this.difficultyInput);
            this.previewInfoBox.Controls.Add(this.nameInput);
            this.previewInfoBox.Location = new System.Drawing.Point(12, 52);
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
            this.quickSaveGroup.Location = new System.Drawing.Point(12, 158);
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
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_info,
            this.tools_Chapter,
            this.tools_Global});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tools_info
            // 
            this.tools_info.Name = "tools_info";
            this.tools_info.Size = new System.Drawing.Size(28, 22);
            this.tools_info.Text = "Info";
            // 
            // tools_Chapter
            // 
            this.tools_Chapter.Name = "tools_Chapter";
            this.tools_Chapter.Size = new System.Drawing.Size(77, 22);
            this.tools_Chapter.Text = "Chapter Stuff";
            // 
            // tools_Global
            // 
            this.tools_Global.Name = "tools_Global";
            this.tools_Global.Size = new System.Drawing.Size(41, 22);
            this.tools_Global.Text = "Global";
            // 
            // PogoSaveEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.quickSaveGroup);
            this.Controls.Add(this.previewInfoBox);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tools_info;
        private System.Windows.Forms.ToolStripLabel tools_Chapter;
        private System.Windows.Forms.ToolStripLabel tools_Global;
        private System.Windows.Forms.Label checkpointLabel;
        private System.Windows.Forms.NumericUpDown chapterCheckpoint;
    }
}


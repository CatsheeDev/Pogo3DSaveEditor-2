using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Pogo3DSaveEditor
{
    public partial class PogoSaveEditor : Form
    {
        public PogoSaveEditor()
        {
            InitializeComponent();
            SaveCheck();
            instance = this; 

        }

        public static PogoSaveEditor instance;

        public string saveFile;
        private string file;
        private dynamic saveData;

        private string defaultFileLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HEDGEWIZARDS\\pogo");

        private string difficulty = null;
        private string chapter = null; 
        private string name = null;
        private FileTypeEnum fileType = FileTypeEnum.None;

        private void difficultyInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            difficulty = TypeConversion.intToDifficulty(difficultyInput.SelectedIndex);
        }

        private void quickSave_Chapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            chapter = TypeConversion.intToChapter(quickSave_Chapter.SelectedIndex);
        }

        private void saveSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saving preview data
            saveData.previewData.name = nameInput.Text;
            saveData.previewData.difficulty = TypeConversion.difficultyToInt(difficultyInput.Text);

            //Saving quick save data
            saveData.quickSaveData.ChapterId.ChapterNumber = TypeConversion.chapterToInt(quickSave_Chapter.Text);
            saveData.quickSaveData.checkpointId.CheckpointNumber = (int)chapterCheckpoint.Value;

            SaveFileDialog fileSaver = new SaveFileDialog();
            fileSaver.Filter = "Save files (*.sav)|*.sav";
            fileSaver.InitialDirectory = defaultFileLocation;
            fileSaver.Title = "Select a Saveslot File";

            if (fileSaver.ShowDialog() == DialogResult.OK)
            {
                string jsonString = JsonConvert.SerializeObject(saveData);
                string fullData = $"{saveData.previewData.difficulty}\n{jsonString}";

                File.WriteAllText(fileSaver.FileName, fullData);

                MessageBox.Show("Successfully saved!! :D", "funnmy save editor", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        //Loading
        private void fileDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpener = new OpenFileDialog();
            fileOpener.Filter = "Save files (*.sav)|*.sav";
            fileOpener.InitialDirectory = defaultFileLocation;
            fileOpener.Title = "Select a Saveslot File";
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                saveFile = fileOpener.FileName;
                fileType = FileTypeEnum.Slot;

                var FileStream = fileOpener.OpenFile();

                using (StreamReader reader = new StreamReader(FileStream))
                {
                    file = reader.ReadToEnd();
                    string[] lines = file.Split('\n');
                    string jsonString = lines[1];

                    saveData = JsonConvert.DeserializeObject<dynamic>(jsonString);

                    //PreviewData
                    nameInput.Text = saveData.previewData.name;
                    difficultyInput.Text = TypeConversion.intToDifficulty(Convert.ToInt32(saveData.previewData.difficulty));

                    //QuickSaveData
                    quickSave_Chapter.Text = TypeConversion.intToChapter(Convert.ToInt32(saveData.quickSaveData.ChapterId.ChapterNumber));
                    chapterCheckpoint.Value = Convert.ToInt32(saveData.quickSaveData.checkpointId.CheckpointNumber);
                }
                SaveCheck();
            }
        }

        void DisableAll()
        {
            nameInput.Enabled = false;
            difficultyInput.Enabled = false;
            quickSave_Chapter.Enabled = false;
            chapterCheckpoint.Enabled = false; 
            saveSaveToolStripMenuItem.Enabled = false;
        }

        void EnableAll()
        {
            nameInput.Enabled = true;
            difficultyInput.Enabled = true;
            quickSave_Chapter.Enabled = true;
            saveSaveToolStripMenuItem.Enabled = true;
            chapterCheckpoint.Enabled = true;
            tools_Global.Enabled = false;
        }
        public void SaveCheck()
        {
            switch (fileType)
            {
                case FileTypeEnum.Slot:
                    EnableAll(); 
                    break;

                case FileTypeEnum.None: 
                    DisableAll();
                    break;

                case FileTypeEnum.Global:
                    DisableAll();
                    tools_Global.Enabled = true;
                    break;
            }
        }
    }
}
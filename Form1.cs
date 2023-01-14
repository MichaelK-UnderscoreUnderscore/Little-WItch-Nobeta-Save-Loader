using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LWNobeta_Save_Edit
{
	public partial class Form1 : Form
	{
		byte[] saveFile;

		public Form1()
		{
			InitializeComponent();
			reloadSaveFolder();
		}

		private void loadSaveData(string saveName)
		{
			saveFile = null;
			labelLoadedFileName.Text = "None";

			try
			{
				File.WriteAllBytes("LittleWitchNobeta_Data/Save/GameSave0" + numericSaveSlot.Value.ToString() + ".dat",
										File.ReadAllBytes("LittleWitchNobeta_Data/Save/" + saveName + ".dat"));
				labelLoadedFileName.Text = saveName;
			}
			catch
			{
				labelLoadedFileName.Text = "Failed to Load...";
			}
		}

		private void backupSaveData(string saveName)
        {
			labelBackupFileName.Text = "None";
			try
			{
				File.WriteAllBytes("LittleWitchNobeta_Data/Save/" + saveName + ".dat",
										File.ReadAllBytes("LittleWitchNobeta_Data/Save/GameSave0" + numericBackupSaveSlot.Value.ToString() + ".dat"));
				labelBackupFileName.Text = saveName;
			}
			catch
			{
				labelBackupFileName.Text = "Failed to backup...";
			}
			reloadSaveFolder();
		}
		private void reloadSaveFolder()
        {
			string[] FilePaths = Directory.GetFiles("LittleWitchNobeta_Data/Save/","*.dat");
			foreach (string FilePath in FilePaths)
            {
				listSaveFolder.Items.Add(FilePath.Substring(28,FilePath.Length-32));
            }

		}

        private void buttonReload_Click(object sender, EventArgs e)
        {
			listSaveFolder.Items.Clear();
			reloadSaveFolder();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
			loadSaveData(listSaveFolder.Text.ToString());
        }

        private void buttonSaveBackup_Click(object sender, EventArgs e)
        {
			backupSaveData(textBoxBackupSaveName.Text);
        }
    }
}

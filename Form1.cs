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
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkSkills.Checked == false)
			{
				labelErrSkillsOoR.Visible = false;
				numChangeMinMax();
			}
			else
			{
				labelErrSkillsOoR.Visible = true;
				numChangeMinMax(-2147483648, 2147483647);
			}
		}

		private void loadSaveData(int saveSlot, bool itemCopy = false)
		{
			labelErrSaveLoaded.Visible = false;
			try
			{               
				saveFile = File.ReadAllBytes("LittleWitchNobeta_Data/Save/Save0" + saveSlot.ToString() + ".dat");
				numREGION.Value = saveFile[12];
				numSPAWN.Value = saveFile[16];
				regionUpdate();

				checkDifficulty.Checked = saveFile[20] == 1;
				checkSkills.Checked = false;

				int HP = BitConverter.ToInt32(saveFile, 60);
				int MP = BitConverter.ToInt32(saveFile, 68);
				int STA = BitConverter.ToInt32(saveFile, 76);
				int STR = BitConverter.ToInt32(saveFile, 84);
				int INT = BitConverter.ToInt32(saveFile, 92);
				int CON = BitConverter.ToInt32(saveFile, 100);

				if (
					(HP > 30) || (MP > 30) ||
					(STA > 30) || (STR > 30) ||
					(INT > 30) || (CON > 30) ||
					(HP < 1) || (MP < 1) ||
					(STA < 1) || (STR < 1) ||
					(INT < 1) || (CON < 1))
				{
					checkSkills.Checked = true;
				}

				numHP.Value = HP;
				numMP.Value = MP;
				numSTA.Value = STA;
				numSTR.Value = STR;
				numINT.Value = INT;
				numCON.Value = CON;

				numARC.Value = saveFile[108];
				numICE.Value = saveFile[112];
				numFIR.Value = saveFile[116];
				numLIG.Value = saveFile[120];
				numWIND.Value = saveFile[52];
				numCOUNTER.Value = saveFile[56];

				numSouls.Value = (decimal)BitConverter.ToSingle(saveFile, 170);

				labelLoad.Visible = true;
				timerLoad.Start();

			}
			catch
			{
				labelErrSaveFileNotExist.Visible = true;
			}
		}

		private void saveSaveData(int saveSlot)
		{
			saveFile[12] = (byte)numREGION.Value;
			saveFile[16] = (byte)numSPAWN.Value;

			saveFile[20] = checkDifficulty.Checked ? (byte)1 : (byte)0;
			BitConverter.GetBytes((int)numHP.Value).CopyTo(saveFile, 60);
			BitConverter.GetBytes((int)numMP.Value).CopyTo(saveFile, 68);
			BitConverter.GetBytes((int)numSTA.Value).CopyTo(saveFile, 76);
			BitConverter.GetBytes((int)numSTR.Value).CopyTo(saveFile, 84);
			BitConverter.GetBytes((int)numINT.Value).CopyTo(saveFile, 92);
			BitConverter.GetBytes((int)numCON.Value).CopyTo(saveFile, 100);

			saveFile[108] = (byte)numARC.Value;
			saveFile[112] = (byte)numICE.Value;
			saveFile[116] = (byte)numFIR.Value;
			saveFile[120] = (byte)numLIG.Value;
			saveFile[52]  = (byte)numWIND.Value;
			saveFile[56]  = (byte)numCOUNTER.Value;

			BitConverter.GetBytes((float)numSouls.Value).CopyTo(saveFile, 170);

			File.WriteAllBytes("LittleWitchNobeta_Data/Save/Save0" + saveSlot.ToString() + ".dat", saveFile);
			labelSave.Visible = true;
			timerSave.Start();
		}

		private void regionUpdate()
		{
			int i = (int)(numREGION.Value * 1000 + numSPAWN.Value);
			switch (i)
			{

				case 1000:
					comboSPAWNPOINT.SelectedIndex = 1;
					break;
				case 2000:
					comboSPAWNPOINT.SelectedIndex = 4;
					break;
				case 2003:
					comboSPAWNPOINT.SelectedIndex = 5;
					break;
				case 2001:
					comboSPAWNPOINT.SelectedIndex = 6;
					break;
				case 2004:
					comboSPAWNPOINT.SelectedIndex = 7;
					break;
				case 3006:
					comboSPAWNPOINT.SelectedIndex = 10;
					break;
				case 3000:
					comboSPAWNPOINT.SelectedIndex = 11;
					break;
				case 3001:
					comboSPAWNPOINT.SelectedIndex = 12;
					break;
				case 3005:
					comboSPAWNPOINT.SelectedIndex = 13;
					break;
				case 4000:
					comboSPAWNPOINT.SelectedIndex = 16;
					break;
				case 4001:
					comboSPAWNPOINT.SelectedIndex = 17;
					break;
				case 4004:
					comboSPAWNPOINT.SelectedIndex = 18;
					break;
				case 0000:
					comboSPAWNPOINT.SelectedIndex = 25;
					break;
				case 2005:
					comboSPAWNPOINT.SelectedIndex = 28;
					break;
				case 2002:
					comboSPAWNPOINT.SelectedIndex = 29;
					break;
				case 3007:
					comboSPAWNPOINT.SelectedIndex = 32;
					break;
				case 3002:
					comboSPAWNPOINT.SelectedIndex = 33;
					numREGION.Value = 3;
					numSPAWN.Value = 2;
					break;
				case 3004:
					comboSPAWNPOINT.SelectedIndex = 34;
					numREGION.Value = 3;
					numSPAWN.Value = 4;
					break;
				case 3003:
					comboSPAWNPOINT.SelectedIndex = 35;
					numREGION.Value = 3;
					numSPAWN.Value = 3;
					break;
				case 4005:
					comboSPAWNPOINT.SelectedIndex = 38;
					numREGION.Value = 3;
					numSPAWN.Value = 5;
					break;
				case 4003:
					comboSPAWNPOINT.SelectedIndex = 39;
					numREGION.Value = 3;
					numSPAWN.Value = 3;
					break;
				default:
					switch (numREGION.Value)
					{
						case 0:
							comboSPAWNPOINT.SelectedIndex = 24;
							break;
						case 1:
							comboSPAWNPOINT.SelectedIndex = 0;
							break;
						case 2:
							comboSPAWNPOINT.SelectedIndex = 3;
							break;
						case 3:
							comboSPAWNPOINT.SelectedIndex = 9;
							break;
						case 4:
							comboSPAWNPOINT.SelectedIndex = 15;
							break;
						default:
							comboSPAWNPOINT.SelectedIndex = 21;
							break;
					}
					break;
			}
		}

		private void numChangeMinMax(int nMin = 1, int nMax = 30)
		{
			numHP.Maximum = nMax;
			numMP.Maximum = nMax;
			numSTA.Maximum = nMax;
			numSTR.Maximum = nMax;
			numINT.Maximum = nMax;
			numCON.Maximum = nMax;

			numHP.Minimum = nMin;
			numMP.Minimum = nMin;
			numSTA.Minimum = nMin;
			numSTR.Minimum = nMin;
			numINT.Minimum = nMin;
			numCON.Minimum = nMin;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			switch (buttonSave.Text)
			{
				case "Cancel":
					buttonSave.Text = "Save Data";
					timerWait.Stop();
					fswSave.EnableRaisingEvents = false;
					labelWait.Visible = false;
					labelWait.Text = ".";
					numSave.Enabled = true;
					break;
				default:
					if (checkHotSave.Checked)
					{
						labelErrSaveFileNotExist.Visible = false;
						try
						{
							fswSave.Filter = "Save0" + numSave.Value.ToString() + ".dat";
							fswSave.EnableRaisingEvents = true;
							timerWait.Enabled = true;
							labelWait.Visible = true;
							numSave.Enabled = false;
							buttonSave.Text = "Cancel";
						}
						catch
						{
							labelErrSaveFileNotExist.Visible = true;
						}
						return;
					}
					if (saveFile != null)
						saveSaveData((int)numSave.Value);
					break;
			}
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			loadSaveData((int)numSave.Value);
		}

		private void numSave_ValueChanged(object sender, EventArgs e)
		{
			labelErrSaveFileNotExist.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form diag = new Form2();
			diag.ShowDialog();
		}

		private void comboSPAWNPOINT_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboSPAWNPOINT.SelectedIndex)
			{
				case 1:
					numREGION.Value = 1;
					numSPAWN.Value = 0;
					break;
				case 4:
					numREGION.Value = 2;
					numSPAWN.Value = 0;
					break;
				case 5:
					numREGION.Value = 2;
					numSPAWN.Value = 3;
					break;
				case 6:
					numREGION.Value = 2;
					numSPAWN.Value = 1;
					break;
				case 7:
					numREGION.Value = 2;
					numSPAWN.Value = 4;
					break;
				case 10:
					numREGION.Value = 3;
					numSPAWN.Value = 6;
					break;
				case 11:
					numREGION.Value = 3;
					numSPAWN.Value = 0;
					break;
				case 12:
					numREGION.Value = 3;
					numSPAWN.Value = 1;
					break;
				case 13:
					numREGION.Value = 3;
					numSPAWN.Value = 5;
					break;
				case 16:
					numREGION.Value = 4;
					numSPAWN.Value = 0;
					break;
				case 17:
					numREGION.Value = 4;
					numSPAWN.Value = 1;
					break;
				case 18:
					numREGION.Value = 4;
					numSPAWN.Value = 4;
					break;
				case 25:
					numREGION.Value = 0;
					numSPAWN.Value = 0;
					break;
				case 28:
					numREGION.Value = 2;
					numSPAWN.Value = 5;
					break;
				case 29:
					numREGION.Value = 2;
					numSPAWN.Value = 2;
					break;
				case 32:
					numREGION.Value = 3;
					numSPAWN.Value = 7;
					break;
				case 33:
					numREGION.Value = 3;
					numSPAWN.Value = 2;
					break;
				case 34:
					numREGION.Value = 3;
					numSPAWN.Value = 4;
					break;
				case 35:
					numREGION.Value = 3;
					numSPAWN.Value = 4;
					break;
				case 38:
					numREGION.Value = 4;
					numSPAWN.Value = 5;
					break;
				case 39:
					numREGION.Value = 4;
					numSPAWN.Value = 3;
					break;
			}

		}

		private void numREGION_ValueChanged(object sender, EventArgs e)
		{
			regionUpdate();
		}

		private void numSPAWN_ValueChanged(object sender, EventArgs e)
		{
			regionUpdate();
		}

		private void buttonItems_Click(object sender, EventArgs e)
		{
			if (saveFile == null)
			{
				labelErrSaveLoaded.Visible = true;
				return;
			}
			Form3 f = new Form3(saveFile);
				f.ShowDialog();
				saveFile = f.saveData;
		}

		private void timerLoad_Tick(object sender, EventArgs e)
		{
			timerLoad.Stop();
			labelLoad.Visible = false;
		}

		private void timerSave_Tick(object sender, EventArgs e)
		{
			timerSave.Stop();
			labelSave.Visible = false;
		}

		private void timerWait_Tick(object sender, EventArgs e)
		{
			switch (labelWait.Text)
			{
				case ".":
					labelWait.Text = "..";
					break;
				case "..":
					labelWait.Text = "...";
					break;
				default:
					labelWait.Text = ".";
					break;
			}
		}

		private void fswSave_Changed(object sender, FileSystemEventArgs e)
		{
			byte[] itemData = new byte[9];
			itemData[0] = saveFile[130];
			itemData[1] = saveFile[138];
			itemData[2] = saveFile[142];
			itemData[3] = saveFile[146];
			itemData[4] = saveFile[150];
			itemData[5] = saveFile[154];
			itemData[6] = saveFile[158];
			itemData[7] = saveFile[162];
			itemData[8] = saveFile[166];

			saveFile = File.ReadAllBytes("LittleWitchNobeta_Data/Save/Save0" + numSave.Value.ToString() + ".dat");

			saveFile[130] = itemData[0];
			saveFile[138] = itemData[1];
			saveFile[142] = itemData[2];
			saveFile[146] = itemData[3];
			saveFile[150] = itemData[5];
			saveFile[154] = itemData[5];
			saveFile[158] = itemData[6];
			saveFile[162] = itemData[7];
			saveFile[166] = itemData[8];

			saveSaveData((int)numSave.Value);

			buttonSave.Text = "Save Data";
			timerWait.Stop();
			fswSave.EnableRaisingEvents = false;
			labelWait.Visible = false;
			labelWait.Text = ".";
			numSave.Enabled = true;
		}
	}
}

using System;
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
    public partial class Form3 : Form
    {
        public byte[] saveData;
        public Form3(byte[] sd)
        {
            InitializeComponent();
            saveData = sd;
            numItemCount.Value = saveData[130];
            numItem1.Value = saveData[138];
            numItem2.Value = saveData[142];
            numItem3.Value = saveData[146];
            numItem4.Value = saveData[150];
            numItem5.Value = saveData[154];
            numItem6.Value = saveData[158];
            numItem7.Value = saveData[162];
            numItem8.Value = saveData[166];
            listItems.SelectedIndex = 0;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            numItem1.Value = listItems.SelectedIndex;
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            numItem2.Value = listItems.SelectedIndex;
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            numItem3.Value = listItems.SelectedIndex;
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            numItem4.Value = listItems.SelectedIndex;
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            numItem5.Value = listItems.SelectedIndex;
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            numItem6.Value = listItems.SelectedIndex;
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            numItem7.Value = listItems.SelectedIndex;
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            numItem8.Value = listItems.SelectedIndex;
        }

        private void numItem1_ValueChanged(object sender, EventArgs e)
        {
            if (numItem1.Value > 28)
            {
                textItem1.Text = (string)listItems.Items[28];
                return;
            }
            textItem1.Text = (string)listItems.Items[(int)numItem1.Value];
        }

        private void numItem2_ValueChanged(object sender, EventArgs e)
        {
            if (numItem2.Value > 28)
            {
                textItem2.Text = (string)listItems.Items[28];
                return;
            }
            textItem2.Text = (string)listItems.Items[(int)numItem2.Value];
        }

        private void numItem3_ValueChanged(object sender, EventArgs e)
        {
            if (numItem3.Value > 28)
            {
                textItem3.Text = (string)listItems.Items[28];
                return;
            }
            textItem3.Text = (string)listItems.Items[(int)numItem3.Value];
        }

        private void numItem4_ValueChanged(object sender, EventArgs e)
        {
            if (numItem4.Value > 28)
            {
                textItem4.Text = (string)listItems.Items[28];
                return;
            }
            textItem4.Text = (string)listItems.Items[(int)numItem4.Value];
        }

        private void numItem5_ValueChanged(object sender, EventArgs e)
        {
            if (numItem5.Value > 28)
            {
                textItem5.Text = (string)listItems.Items[28];
                return;
            }
            textItem5.Text = (string)listItems.Items[(int)numItem5.Value];
        }

        private void numItem6_ValueChanged(object sender, EventArgs e)
        {
            if (numItem6.Value > 28)
            {
                textItem6.Text = (string)listItems.Items[28];
                return;
            }
            textItem6.Text = (string)listItems.Items[(int)numItem6.Value];
        }

        private void numItem7_ValueChanged(object sender, EventArgs e)
        {
            if (numItem7.Value > 28)
            {
                textItem7.Text = (string)listItems.Items[28];
                return;
            }
            textItem7.Text = (string)listItems.Items[(int)numItem7.Value];
        }

        private void numItem8_ValueChanged(object sender, EventArgs e)
        {
            if (numItem8.Value > 28)
            {
                textItem8.Text = (string)listItems.Items[28];
                return;
            }
            textItem8.Text = (string)listItems.Items[(int)numItem8.Value];
        }

        private void numItemCount_ValueChanged(object sender, EventArgs e)
        {
            textItem8.Enabled = false;
            textItem7.Enabled = false;
            textItem6.Enabled = false;
            textItem5.Enabled = false;

            switch (numItemCount.Value)
            {
                case 8:
                    textItem8.Enabled = true;
                    goto case 7;
                case 7:
                    textItem7.Enabled = true;
                    goto case 6;
                case 6:
                    textItem6.Enabled = true;
                    goto case 5;
                case 5:
                    textItem5.Enabled = true;
                    break;
            }    
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listItems.SelectedIndex)
            {
                case 1:
                    richItemText.Text = "Restore 120 Health";
                    break;
                case 2:
                    richItemText.Text = "Restore 120 Mana";
                    break;
                case 3:
                    richItemText.Text = "HP Recvovers 100%, increases HP limit";
                    break;
                case 4:
                    richItemText.Text = "MP Recvovers 100%, increases MP limit";
                    break;
                case 5:
                    richItemText.Text = "SP回復100%、增加SP最大上限\n(SP recovery 100%, increase SP maximum upper limit)";
                    break;
                case 12:
                    richItemText.Text = "Restore 240 Health";
                    break;
                case 13:
                    richItemText.Text = "Restore 360 Health";
                    break;
                case 14:
                    richItemText.Text = "Restore 240 Mana";
                    break;
                case 15:
                    richItemText.Text = "Restore 360 Mana";
                    break;
                case 17:
                    richItemText.Text = "Restore 50% Health with an increased curse value";
                    break;
                case 18:
                    richItemText.Text = "Restore 50% Mana with an increased curse value";
                    break;
                case 19:
                    richItemText.Text = "Increase a little defense for a while";
                    break;
                case 20:
                    richItemText.Text = "Increase defense for a while";
                    break;
                case 21:
                    richItemText.Text = "Increase great defense for a while";
                    break;
                case 22:
                    richItemText.Text = "Drop it on the ground to form a temporary area for minor mana regeneration";
                    break;
                case 23:
                    richItemText.Text = "Drop it on the ground to form a temporary area for mana regeneration";
                    break;
                case 24:
                    richItemText.Text = "Drop it on the ground to form a temporary area for major mana regeneration";
                    break;
                case 25:
                    richItemText.Text = "Drop it on the ground to form a temporary area for minor health regeneration";
                    break;
                case 26:
                    richItemText.Text = "Drop it on the ground to form a temporary area for health regeneration";
                    break;
                case 27:
                    richItemText.Text = "Drop it on the ground to form a temporary area for major health regeneration";
                    break;
                default:
                    richItemText.Text = "";
                    break;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            saveData[130] = (byte)numItemCount.Value;
            saveData[138] = (byte)numItem1.Value;
            saveData[142] = (byte)numItem2.Value;
            saveData[146] = (byte)numItem3.Value;
            saveData[150] = (byte)numItem4.Value;
            saveData[154] = (byte)numItem5.Value;
            saveData[158] = (byte)numItem6.Value;
            saveData[162] = (byte)numItem7.Value;
            saveData[166] = (byte)numItem8.Value;
            this.Close();
        }
    }
}

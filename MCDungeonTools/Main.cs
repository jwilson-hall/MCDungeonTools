using MCDungeonTools.assets;
using MCDungeonTools.assets.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MCDungeonTools
{
    public partial class Main : Form
    {
        public Main()
        {
            //MessageBox.Show("PLEASE NOTE. This tool may cause your save to corrupt so make sure you have a backup.");
            InitializeComponent();
            dtoolsLoaded();
        }
        //-------------------------Objects-----------------------------
        readonly OpenFileDialog SelectFile = new OpenFileDialog(); 
        root jDataRoot = new root();
        //-------------------------Objects-----------------------------
        //-------------------------Variables-----------------------------
        private string SaveFile;
        private string saveFileData;
        private bool fileLoaded=false;
        private bool dtoolsLoaded()
        {
            if (File.Exists("dtools.exe"))
            {
                lbl_dtoolsStatus.ForeColor = Color.Green;
                lbl_dtoolsStatus.Text = "dtools.exe FOUND";
                return true;
            }
            lbl_dtoolsStatus.ForeColor = Color.Red;
            lbl_dtoolsStatus.Text = "dtools.exe NOT FOUND";
            return false;
        }
        private List<string> allEnchants = new List<string>();
        //-------------------------Variables-----------------------------
        //-------------------------Form Events-----------------------------
        private void btn_SaveLocation_Click(object sender, EventArgs e)
        {
            resetForm();
            if (dtoolsLoaded()==true)
            {
                try
                {
                    SelectFile.ShowDialog();
                    SaveFile = SelectFile.FileName;
                    lbl_SavePath.Text = Path.GetFileName(SaveFile);
                    if (SaveFile != "")
                    {
                        fileLoaded = true;
                        enableForm();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("No file selected");
                    fileLoaded = false;
                }
                if (fileLoaded == true)
                {
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();
                    cmd.StandardInput.WriteLine("dtools.exe " + '"' + SaveFile + '"');
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                    string tempFileData;
                    try
                    {
                        tempFileData = File.ReadAllText(Path.GetDirectoryName(SaveFile)+"\\" + Path.GetFileNameWithoutExtension(SaveFile) + ".json");
                        if (tempFileData.Contains("4294967295"))
                        {
                            saveFileData = tempFileData.Replace("4294967295", "180");

                        }
                        else
                        {
                            saveFileData = tempFileData;
                        }
                        deserialiseJSON(saveFileData);
                        loadObjects();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("File not found");
                        fileLoaded = false;
                        resetForm();
                    }
                    //collectEnchants();
                }
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            jDataRoot.currency[0].count = Convert.ToInt32(txt_currencyEmeralds.Text);
            jDataRoot.finishedObjectiveTags.Objective_RescuedVillager = Convert.ToInt32(txt_rescuedVil.Text);
            jDataRoot.xp = Convert.ToInt32(txt_XP.Text);
            File.WriteAllText(Path.GetDirectoryName(SaveFile) + "\\" + Path.GetFileNameWithoutExtension(SaveFile) + ".json", serializeJSON());
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("dtools.exe " + '"' + Path.GetDirectoryName(SaveFile) + "\\" + Path.GetFileNameWithoutExtension(SaveFile) + ".json" + '"');
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            resetForm();
            MessageBox.Show("File has been saved and encrypted back to a .dat File");
        }

        private void cBox_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileLoaded == true)
            {
                if (jDataRoot.items[cBox_Items.SelectedIndex].equipmentSlot == null)
                {
                    lbl_slotorIndex.Text = "Inventory Index: " + jDataRoot.items[cBox_Items.SelectedIndex].inventoryIndex.ToString();

                }
                else
                {
                    lbl_slotorIndex.Text = jDataRoot.items[cBox_Items.SelectedIndex].equipmentSlot;
                }
                cBox_Enchants.DataSource = jDataRoot.items[cBox_Items.SelectedIndex].enchantments;
                cBox_Enchants.DisplayMember = "id";
                txt_power.Text = jDataRoot.items[cBox_Items.SelectedIndex].power.ToString();

                if (jDataRoot.items[cBox_Items.SelectedIndex].enchantments == null)
                {
                    cBox_Enchants.Enabled = false;
                    cBox_EnchantLevel.Enabled = false;
                }
                else
                {
                    cBox_Enchants.Enabled = true;
                    cBox_EnchantLevel.Enabled = true;
                }
            }
        }

        private void cBox_Enchants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileLoaded == true)
            {
                if (jDataRoot.items[cBox_Items.SelectedIndex].enchantments != null)
                {
                    cBox_EnchantLevel.SelectedIndex = jDataRoot.items[cBox_Items.SelectedIndex].enchantments[cBox_Enchants.SelectedIndex].level;
                }
            }

        }

        private void cBox_Items_DropDown(object sender, EventArgs e)
        {

        }

        private void cBox_EnchantLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            jDataRoot.items[cBox_Items.SelectedIndex].enchantments[cBox_Enchants.SelectedIndex].level = cBox_EnchantLevel.SelectedIndex;
        }

        private void txt_power_TextChanged(object sender, EventArgs e)
        {
            if (fileLoaded == true)
            {
                try
                {
                    jDataRoot.items[cBox_Items.SelectedIndex].power = Convert.ToDouble(txt_power.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid power entry");
                    txt_power.Text = jDataRoot.items[cBox_Items.SelectedIndex].power.ToString();
                }
            }
        }
        private void txt_currencyEmeralds_TextChanged(object sender, EventArgs e)
        {
            if (fileLoaded == true)
            {
                try
                {
                    jDataRoot.currency[0].count = Convert.ToInt32(txt_currencyEmeralds.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid power entry");
                    txt_power.Text = jDataRoot.currency[0].count.ToString();
                }
            }
        }
        private void listBox_runes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Unchecked)
            {
                if (!jDataRoot.progressionKeys.Contains(listBox_runes.Items[e.Index].ToString()))
                {
                    jDataRoot.progressionKeys.Add(listBox_runes.Items[e.Index].ToString());
                }
            }
            else if (e.CurrentValue == CheckState.Checked)
            {
                jDataRoot.progressionKeys.Remove(listBox_runes.Items[e.Index].ToString());
            }
        }
        private void listview_mobs_Killed_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(allMobs[listview_mobs_Killed.SelectedIndex].mobKills);
            /*editMobKills tempEdit = new editMobKills(allMobs[listview_mobs_Killed.SelectedIndex].mobKills);
            tempEdit.Show();*/
            
        }
        //-------------------------Form Events-----------------------------
        //-------------------------Functions-----------------------------

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                jDataRoot = JsonConvert.DeserializeObject<root>(strJSON);
            }
            catch (JsonReaderException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private string serializeJSON()
        {
            return sroot = JsonConvert.SerializeObject(jDataRoot, Formatting.Indented);
        }
        private void loadObjects()
        {
            try
            {
                txt_currencyEmeralds.Text = jDataRoot.currency[0].count.ToString();
                txt_XP.Text = jDataRoot.xp.ToString();
                txt_rescuedVil.Text = jDataRoot.finishedObjectiveTags.Objective_RescuedVillager.ToString();
                cBox_Items.DataSource = jDataRoot.items;
                cBox_Items.DisplayMember = "type";
                for (int i = 0; i < listBox_runes.Items.Count; i++)
                {
                    for (int j = 0; j < jDataRoot.progressionKeys.Count; j++)
                    {
                        if (listBox_runes.Items[i].ToString()==jDataRoot.progressionKeys[j].ToString())
                        {
                            listBox_runes.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }
            }
            catch (Exception)
            {

                
            }   
        }
        private void enableForm()
        {
            txt_currencyEmeralds.Enabled = true;
            txt_rescuedVil.Enabled = true;
            txt_power.Enabled = true;
            cBox_EnchantLevel.Enabled = true;
            cBox_Enchants.Enabled = true;
            cBox_Items.Enabled = true;
            btn_save.Enabled = true;
            txt_XP.Enabled = true;
            listBox_runes.Enabled = true;
        }
        private void resetForm()
        {
            SelectFile.FileName = "";
            saveFileData = "";
            SaveFile = "";
            fileLoaded = false;
            txt_currencyEmeralds.Clear();
            txt_currencyEmeralds.Enabled = false;
            txt_rescuedVil.Clear();
            txt_rescuedVil.Enabled = false;
            lbl_SavePath.Text = "-";
            txt_power.Text = "";
            txt_power.Enabled = false;
            cBox_EnchantLevel.Enabled = false;
            cBox_Enchants.DataSource = null;
            cBox_Enchants.Items.Clear();
            cBox_Enchants.Enabled = false;
            cBox_Items.DataSource = null;
            cBox_Items.Items.Clear();
            cBox_Items.Enabled = false;
            btn_save.Enabled = false;
            txt_XP.Enabled = false;
            txt_XP.Text = "";
            for (int i = 0; i < listBox_runes.Items.Count; i++)
            {
                listBox_runes.SetItemCheckState(i, CheckState.Unchecked);
            }
            listBox_runes.Enabled = false;
        }
        string sroot = "";
        private void collectEnchants()
        {
            for (int i = 0; i < jDataRoot.items.Count; i++)
            {
                if (jDataRoot.items[i].enchantments != null)
                {
                    for (int j = 0; j < jDataRoot.items[i].enchantments.Count; j++)
                    {
                        
                        if (!allEnchants.Contains(jDataRoot.items[i].enchantments[j].id.ToString()))
                        {
                            allEnchants.Add(jDataRoot.items[i].enchantments[j].id.ToString());
                        }
                    }
                }
            }
            foreach (var item in allEnchants)
            {
                Console.WriteLine(item);
            }
        }
        //-------------------------Functions-----------------------------



    }
}

using MCDungeonTools.assets;
using MCDungeonTools.assets.classes;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MCDungeonTools
{
    public partial class Main : Form
    {
        public Main()
        {
            MessageBox.Show("PLEASE NOTE. This tool may cause your save to corrupt so make sure you have a backup.");
            InitializeComponent();
        }
        //-------------------------Objects-----------------------------
        readonly OpenFileDialog SelectFile = new OpenFileDialog();
        private string SaveFile;
        private string saveFileData;
        root jDataRoot = new root();
        //-------------------------Objects-----------------------------
        private void btn_SaveLocation_Click(object sender, EventArgs e)
        {
            SelectFile.ShowDialog();
            SaveFile = SelectFile.FileName;
            lbl_SavePath.Text = Path.GetFileName(SaveFile);
            
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("dtools.exe "+ '"'+SaveFile+'"');
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            saveFileData= File.ReadAllText(Path.GetFileNameWithoutExtension(SaveFile) + ".json");
            deserialiseJSON(saveFileData);
            //Console.WriteLine(jDataRoot.currency[0].type = "Emerald");
            loadObjects();
        }
        private void deserialiseJSON(string strJSON)
        {
            jDataRoot = JsonConvert.DeserializeObject<root>(strJSON);
            /*Console.WriteLine("Converted JSON data" + jDataRoot.currency[0].count);
            Console.WriteLine(jDataRoot.clone.ToString());
            Console.WriteLine(jDataRoot.lobbychest_progress.ToString());
            Console.WriteLine(jDataRoot.xp.ToString());
            Console.WriteLine(jDataRoot.merchantData.Default__VillageMerchantDef.quests.Quest1.questState.targetCount.ToString());*/
            //debugOutput(jData.pendingRewardItem.ToString());
            
        }
        private string serializeJSON()
        {
            return sroot = JsonConvert.SerializeObject(jDataRoot, Formatting.Indented);
        }
        private void loadObjects()
        {
            txt_currencyEmeralds.Text = jDataRoot.currency[0].count.ToString();
            txt_rescuedVil.Text = jDataRoot.finishedObjectiveTags.Objective_RescuedVillager.ToString();
            foreach (var item in jDataRoot.items)
            {
                Console.WriteLine(item.type);
            }
        }
        private void resetForm()
        {
            txt_currencyEmeralds.Clear();
            txt_rescuedVil.Clear();
            lbl_SavePath.Text = "-";
        }
        string sroot = "";
        private void btn_save_Click(object sender, EventArgs e)
        {
            jDataRoot.currency[0].count = Convert.ToInt32(txt_currencyEmeralds.Text);
            jDataRoot.finishedObjectiveTags.Objective_RescuedVillager = Convert.ToInt32(txt_rescuedVil.Text);
            File.WriteAllText(Path.GetFileNameWithoutExtension(SaveFile) + ".json",serializeJSON());
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("dtools.exe " + '"' + Path.GetFileNameWithoutExtension(SaveFile) + ".json" + '"');
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            resetForm();
            MessageBox.Show("File has been saved and encrypted back to a .dat File");
        }
    }
}

namespace MCDungeonTools
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_SaveLocation = new System.Windows.Forms.Button();
            this.lbl_SavePath = new System.Windows.Forms.Label();
            this.grp_savegame = new System.Windows.Forms.GroupBox();
            this.listBox_runes = new System.Windows.Forms.CheckedListBox();
            this.lbl_XP = new System.Windows.Forms.Label();
            this.txt_XP = new System.Windows.Forms.TextBox();
            this.gBox_EditItems = new System.Windows.Forms.GroupBox();
            this.txt_power = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_EnchantLevel = new System.Windows.Forms.ComboBox();
            this.lbl_ELevel = new System.Windows.Forms.Label();
            this.cBox_Enchants = new System.Windows.Forms.ComboBox();
            this.lbl_enchants = new System.Windows.Forms.Label();
            this.lbl_slotorIndex = new System.Windows.Forms.Label();
            this.lbl_slot = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cBox_Items = new System.Windows.Forms.ComboBox();
            this.lbl_rescuedVil = new System.Windows.Forms.Label();
            this.txt_rescuedVil = new System.Windows.Forms.TextBox();
            this.lbl_emeralds = new System.Windows.Forms.Label();
            this.txt_currencyEmeralds = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_dtoolsStatus = new System.Windows.Forms.Label();
            this.grp_savegame.SuspendLayout();
            this.gBox_EditItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveLocation
            // 
            this.btn_SaveLocation.Location = new System.Drawing.Point(12, 12);
            this.btn_SaveLocation.Name = "btn_SaveLocation";
            this.btn_SaveLocation.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveLocation.TabIndex = 0;
            this.btn_SaveLocation.Text = "Select";
            this.btn_SaveLocation.UseVisualStyleBackColor = true;
            this.btn_SaveLocation.Click += new System.EventHandler(this.btn_SaveLocation_Click);
            // 
            // lbl_SavePath
            // 
            this.lbl_SavePath.AutoSize = true;
            this.lbl_SavePath.Location = new System.Drawing.Point(93, 17);
            this.lbl_SavePath.Name = "lbl_SavePath";
            this.lbl_SavePath.Size = new System.Drawing.Size(10, 13);
            this.lbl_SavePath.TabIndex = 1;
            this.lbl_SavePath.Text = "-";
            // 
            // grp_savegame
            // 
            this.grp_savegame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_savegame.Controls.Add(this.listBox_runes);
            this.grp_savegame.Controls.Add(this.lbl_XP);
            this.grp_savegame.Controls.Add(this.txt_XP);
            this.grp_savegame.Controls.Add(this.gBox_EditItems);
            this.grp_savegame.Controls.Add(this.lbl_rescuedVil);
            this.grp_savegame.Controls.Add(this.txt_rescuedVil);
            this.grp_savegame.Controls.Add(this.lbl_emeralds);
            this.grp_savegame.Controls.Add(this.txt_currencyEmeralds);
            this.grp_savegame.Location = new System.Drawing.Point(13, 42);
            this.grp_savegame.Name = "grp_savegame";
            this.grp_savegame.Size = new System.Drawing.Size(659, 394);
            this.grp_savegame.TabIndex = 2;
            this.grp_savegame.TabStop = false;
            this.grp_savegame.Text = "Save Game";
            // 
            // listBox_runes
            // 
            this.listBox_runes.Enabled = false;
            this.listBox_runes.FormattingEnabled = true;
            this.listBox_runes.Items.AddRange(new object[] {
            "shopkeeper_unlocked",
            "mysterymerchant_unlocked",
            "giftwrapper_unlocked",
            "blacksmith_unlocked",
            "luxurymerchant_unlocked",
            "unlocked-rune-o",
            "unlocked-rune-i",
            "unlocked-rune-a",
            "unlocked-rune-h",
            "unlocked-rune-v",
            "unlocked-rune-n",
            "unlocked-rune-e",
            "unlocked-rune-p",
            "unlocked-rune-t",
            "RuneGateDiscovered",
            "rune-gate-open",
            "lobby_bridge",
            "op_deluxechest",
            "extended-lobby-chest",
            "lobby-deluxechest-02",
            "lobby-deluxechest-01"});
            this.listBox_runes.Location = new System.Drawing.Point(6, 113);
            this.listBox_runes.Name = "listBox_runes";
            this.listBox_runes.Size = new System.Drawing.Size(170, 274);
            this.listBox_runes.TabIndex = 7;
            this.listBox_runes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBox_runes_ItemCheck);
            // 
            // lbl_XP
            // 
            this.lbl_XP.AutoSize = true;
            this.lbl_XP.Location = new System.Drawing.Point(120, 21);
            this.lbl_XP.Name = "lbl_XP";
            this.lbl_XP.Size = new System.Drawing.Size(21, 13);
            this.lbl_XP.TabIndex = 6;
            this.lbl_XP.Text = "XP";
            // 
            // txt_XP
            // 
            this.txt_XP.Enabled = false;
            this.txt_XP.Location = new System.Drawing.Point(123, 37);
            this.txt_XP.Name = "txt_XP";
            this.txt_XP.Size = new System.Drawing.Size(100, 20);
            this.txt_XP.TabIndex = 5;
            // 
            // gBox_EditItems
            // 
            this.gBox_EditItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBox_EditItems.Controls.Add(this.txt_power);
            this.gBox_EditItems.Controls.Add(this.label1);
            this.gBox_EditItems.Controls.Add(this.cBox_EnchantLevel);
            this.gBox_EditItems.Controls.Add(this.lbl_ELevel);
            this.gBox_EditItems.Controls.Add(this.cBox_Enchants);
            this.gBox_EditItems.Controls.Add(this.lbl_enchants);
            this.gBox_EditItems.Controls.Add(this.lbl_slotorIndex);
            this.gBox_EditItems.Controls.Add(this.lbl_slot);
            this.gBox_EditItems.Controls.Add(this.lbl_item);
            this.gBox_EditItems.Controls.Add(this.cBox_Items);
            this.gBox_EditItems.Location = new System.Drawing.Point(453, 20);
            this.gBox_EditItems.Name = "gBox_EditItems";
            this.gBox_EditItems.Size = new System.Drawing.Size(200, 368);
            this.gBox_EditItems.TabIndex = 4;
            this.gBox_EditItems.TabStop = false;
            this.gBox_EditItems.Text = "Edit Items";
            // 
            // txt_power
            // 
            this.txt_power.Enabled = false;
            this.txt_power.Location = new System.Drawing.Point(69, 143);
            this.txt_power.Name = "txt_power";
            this.txt_power.Size = new System.Drawing.Size(125, 20);
            this.txt_power.TabIndex = 9;
            this.txt_power.TextChanged += new System.EventHandler(this.txt_power_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Power";
            // 
            // cBox_EnchantLevel
            // 
            this.cBox_EnchantLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_EnchantLevel.Enabled = false;
            this.cBox_EnchantLevel.FormattingEnabled = true;
            this.cBox_EnchantLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cBox_EnchantLevel.Location = new System.Drawing.Point(69, 108);
            this.cBox_EnchantLevel.Name = "cBox_EnchantLevel";
            this.cBox_EnchantLevel.Size = new System.Drawing.Size(125, 21);
            this.cBox_EnchantLevel.TabIndex = 7;
            this.cBox_EnchantLevel.SelectedIndexChanged += new System.EventHandler(this.cBox_EnchantLevel_SelectedIndexChanged);
            // 
            // lbl_ELevel
            // 
            this.lbl_ELevel.AutoSize = true;
            this.lbl_ELevel.Location = new System.Drawing.Point(11, 111);
            this.lbl_ELevel.Name = "lbl_ELevel";
            this.lbl_ELevel.Size = new System.Drawing.Size(45, 13);
            this.lbl_ELevel.TabIndex = 6;
            this.lbl_ELevel.Text = "E/Level";
            // 
            // cBox_Enchants
            // 
            this.cBox_Enchants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Enchants.Enabled = false;
            this.cBox_Enchants.FormattingEnabled = true;
            this.cBox_Enchants.Location = new System.Drawing.Point(69, 72);
            this.cBox_Enchants.Name = "cBox_Enchants";
            this.cBox_Enchants.Size = new System.Drawing.Size(125, 21);
            this.cBox_Enchants.TabIndex = 5;
            this.cBox_Enchants.SelectedIndexChanged += new System.EventHandler(this.cBox_Enchants_SelectedIndexChanged);
            // 
            // lbl_enchants
            // 
            this.lbl_enchants.AutoSize = true;
            this.lbl_enchants.Location = new System.Drawing.Point(11, 75);
            this.lbl_enchants.Name = "lbl_enchants";
            this.lbl_enchants.Size = new System.Drawing.Size(52, 13);
            this.lbl_enchants.TabIndex = 4;
            this.lbl_enchants.Text = "Enchants";
            // 
            // lbl_slotorIndex
            // 
            this.lbl_slotorIndex.AutoSize = true;
            this.lbl_slotorIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slotorIndex.Location = new System.Drawing.Point(49, 50);
            this.lbl_slotorIndex.Name = "lbl_slotorIndex";
            this.lbl_slotorIndex.Size = new System.Drawing.Size(13, 16);
            this.lbl_slotorIndex.TabIndex = 3;
            this.lbl_slotorIndex.Text = "-";
            // 
            // lbl_slot
            // 
            this.lbl_slot.AutoSize = true;
            this.lbl_slot.Location = new System.Drawing.Point(11, 50);
            this.lbl_slot.Name = "lbl_slot";
            this.lbl_slot.Size = new System.Drawing.Size(25, 13);
            this.lbl_slot.TabIndex = 2;
            this.lbl_slot.Text = "Slot";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(11, 24);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(27, 13);
            this.lbl_item.TabIndex = 1;
            this.lbl_item.Text = "Item";
            // 
            // cBox_Items
            // 
            this.cBox_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Items.Enabled = false;
            this.cBox_Items.FormattingEnabled = true;
            this.cBox_Items.Location = new System.Drawing.Point(44, 19);
            this.cBox_Items.Name = "cBox_Items";
            this.cBox_Items.Size = new System.Drawing.Size(150, 21);
            this.cBox_Items.TabIndex = 0;
            this.cBox_Items.DropDown += new System.EventHandler(this.cBox_Items_DropDown);
            this.cBox_Items.SelectedIndexChanged += new System.EventHandler(this.cBox_Items_SelectedIndexChanged);
            // 
            // lbl_rescuedVil
            // 
            this.lbl_rescuedVil.AutoSize = true;
            this.lbl_rescuedVil.Location = new System.Drawing.Point(7, 70);
            this.lbl_rescuedVil.Name = "lbl_rescuedVil";
            this.lbl_rescuedVil.Size = new System.Drawing.Size(92, 13);
            this.lbl_rescuedVil.TabIndex = 3;
            this.lbl_rescuedVil.Text = "Rescued Villagers";
            // 
            // txt_rescuedVil
            // 
            this.txt_rescuedVil.Enabled = false;
            this.txt_rescuedVil.Location = new System.Drawing.Point(7, 86);
            this.txt_rescuedVil.Name = "txt_rescuedVil";
            this.txt_rescuedVil.Size = new System.Drawing.Size(100, 20);
            this.txt_rescuedVil.TabIndex = 2;
            // 
            // lbl_emeralds
            // 
            this.lbl_emeralds.AutoSize = true;
            this.lbl_emeralds.Location = new System.Drawing.Point(7, 20);
            this.lbl_emeralds.Name = "lbl_emeralds";
            this.lbl_emeralds.Size = new System.Drawing.Size(50, 13);
            this.lbl_emeralds.TabIndex = 1;
            this.lbl_emeralds.Text = "Emeralds";
            // 
            // txt_currencyEmeralds
            // 
            this.txt_currencyEmeralds.Enabled = false;
            this.txt_currencyEmeralds.Location = new System.Drawing.Point(7, 37);
            this.txt_currencyEmeralds.Name = "txt_currencyEmeralds";
            this.txt_currencyEmeralds.Size = new System.Drawing.Size(100, 20);
            this.txt_currencyEmeralds.TabIndex = 0;
            this.txt_currencyEmeralds.TextChanged += new System.EventHandler(this.txt_currencyEmeralds_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(597, 454);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_dtoolsStatus
            // 
            this.lbl_dtoolsStatus.AutoSize = true;
            this.lbl_dtoolsStatus.ForeColor = System.Drawing.Color.Green;
            this.lbl_dtoolsStatus.Location = new System.Drawing.Point(13, 443);
            this.lbl_dtoolsStatus.Name = "lbl_dtoolsStatus";
            this.lbl_dtoolsStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_dtoolsStatus.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 489);
            this.Controls.Add(this.lbl_dtoolsStatus);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grp_savegame);
            this.Controls.Add(this.lbl_SavePath);
            this.Controls.Add(this.btn_SaveLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "MCDungeon Tools";
            this.grp_savegame.ResumeLayout(false);
            this.grp_savegame.PerformLayout();
            this.gBox_EditItems.ResumeLayout(false);
            this.gBox_EditItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveLocation;
        private System.Windows.Forms.Label lbl_SavePath;
        private System.Windows.Forms.GroupBox grp_savegame;
        private System.Windows.Forms.Label lbl_emeralds;
        private System.Windows.Forms.TextBox txt_currencyEmeralds;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_rescuedVil;
        private System.Windows.Forms.TextBox txt_rescuedVil;
        private System.Windows.Forms.GroupBox gBox_EditItems;
        private System.Windows.Forms.ComboBox cBox_Items;
        private System.Windows.Forms.Label lbl_slotorIndex;
        private System.Windows.Forms.Label lbl_slot;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.ComboBox cBox_Enchants;
        private System.Windows.Forms.Label lbl_enchants;
        private System.Windows.Forms.ComboBox cBox_EnchantLevel;
        private System.Windows.Forms.Label lbl_ELevel;
        private System.Windows.Forms.TextBox txt_power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_XP;
        private System.Windows.Forms.TextBox txt_XP;
        private System.Windows.Forms.CheckedListBox listBox_runes;
        private System.Windows.Forms.Label lbl_dtoolsStatus;
    }
}


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
            this.lbl_rescuedVil = new System.Windows.Forms.Label();
            this.txt_rescuedVil = new System.Windows.Forms.TextBox();
            this.lbl_emeralds = new System.Windows.Forms.Label();
            this.txt_currencyEmeralds = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBox_Items = new System.Windows.Forms.ComboBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_slot = new System.Windows.Forms.Label();
            this.lbl_slotorIndex = new System.Windows.Forms.Label();
            this.lbl_enchants = new System.Windows.Forms.Label();
            this.cBox_Enchants = new System.Windows.Forms.ComboBox();
            this.grp_savegame.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.grp_savegame.Controls.Add(this.groupBox1);
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
            this.txt_currencyEmeralds.Location = new System.Drawing.Point(7, 37);
            this.txt_currencyEmeralds.Name = "txt_currencyEmeralds";
            this.txt_currencyEmeralds.Size = new System.Drawing.Size(100, 20);
            this.txt_currencyEmeralds.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(597, 454);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBox_Enchants);
            this.groupBox1.Controls.Add(this.lbl_enchants);
            this.groupBox1.Controls.Add(this.lbl_slotorIndex);
            this.groupBox1.Controls.Add(this.lbl_slot);
            this.groupBox1.Controls.Add(this.lbl_item);
            this.groupBox1.Controls.Add(this.cBox_Items);
            this.groupBox1.Location = new System.Drawing.Point(453, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Items";
            // 
            // cBox_Items
            // 
            this.cBox_Items.FormattingEnabled = true;
            this.cBox_Items.Location = new System.Drawing.Point(44, 19);
            this.cBox_Items.Name = "cBox_Items";
            this.cBox_Items.Size = new System.Drawing.Size(150, 21);
            this.cBox_Items.TabIndex = 0;
            this.cBox_Items.SelectedIndexChanged += new System.EventHandler(this.cBox_Items_SelectedIndexChanged);
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
            // lbl_slot
            // 
            this.lbl_slot.AutoSize = true;
            this.lbl_slot.Location = new System.Drawing.Point(11, 50);
            this.lbl_slot.Name = "lbl_slot";
            this.lbl_slot.Size = new System.Drawing.Size(25, 13);
            this.lbl_slot.TabIndex = 2;
            this.lbl_slot.Text = "Slot";
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
            // lbl_enchants
            // 
            this.lbl_enchants.AutoSize = true;
            this.lbl_enchants.Location = new System.Drawing.Point(11, 75);
            this.lbl_enchants.Name = "lbl_enchants";
            this.lbl_enchants.Size = new System.Drawing.Size(52, 13);
            this.lbl_enchants.TabIndex = 4;
            this.lbl_enchants.Text = "Enchants";
            // 
            // cBox_Enchants
            // 
            this.cBox_Enchants.FormattingEnabled = true;
            this.cBox_Enchants.Location = new System.Drawing.Point(69, 72);
            this.cBox_Enchants.Name = "cBox_Enchants";
            this.cBox_Enchants.Size = new System.Drawing.Size(125, 21);
            this.cBox_Enchants.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 489);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grp_savegame);
            this.Controls.Add(this.lbl_SavePath);
            this.Controls.Add(this.btn_SaveLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "MCDungeon Tools";
            this.grp_savegame.ResumeLayout(false);
            this.grp_savegame.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBox_Items;
        private System.Windows.Forms.Label lbl_slotorIndex;
        private System.Windows.Forms.Label lbl_slot;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.ComboBox cBox_Enchants;
        private System.Windows.Forms.Label lbl_enchants;
    }
}


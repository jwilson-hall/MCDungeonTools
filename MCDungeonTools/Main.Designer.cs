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
            this.lbl_emeralds = new System.Windows.Forms.Label();
            this.txt_currencyEmeralds = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_rescuedVil = new System.Windows.Forms.TextBox();
            this.lbl_rescuedVil = new System.Windows.Forms.Label();
            this.grp_savegame.SuspendLayout();
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
            // txt_rescuedVil
            // 
            this.txt_rescuedVil.Location = new System.Drawing.Point(7, 86);
            this.txt_rescuedVil.Name = "txt_rescuedVil";
            this.txt_rescuedVil.Size = new System.Drawing.Size(100, 20);
            this.txt_rescuedVil.TabIndex = 2;
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
    }
}


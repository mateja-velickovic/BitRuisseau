namespace Frontend
{
    sealed partial class HouseUI_mvc
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
            _agent.Stop();
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
            time = new Label();
            bilan = new Label();
            process1 = new System.Diagnostics.Process();
            pictureBox1 = new PictureBox();
            txtConsole = new RichTextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            wallet = new Label();
            ups = new Label();
            playstation = new CheckBox();
            beer = new CheckBox();
            pompe = new CheckBox();
            pictureBox5 = new PictureBox();
            ups_total = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            time.Location = new Point(162, 146);
            time.Name = "time";
            time.Size = new Size(78, 28);
            time.TabIndex = 1;
            time.Text = " 00:00";
            // 
            // bilan
            // 
            bilan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bilan.AutoSize = true;
            bilan.BackColor = Color.Transparent;
            bilan.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            bilan.Location = new Point(1062, 230);
            bilan.Name = "bilan";
            bilan.Size = new Size(79, 28);
            bilan.TabIndex = 7;
            bilan.Text = "0.0Kw";
            bilan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ImageLocation = "C:\\Users\\pe04uhp\\Desktop\\powercher\\imgs\\ps5.png";
            pictureBox1.Location = new Point(121, 324);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtConsole
            // 
            txtConsole.Location = new Point(12, 3);
            txtConsole.Name = "txtConsole";
            txtConsole.Size = new Size(100, 96);
            txtConsole.TabIndex = 9;
            txtConsole.Text = "";
            txtConsole.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ImageLocation = "C:\\Users\\pe04uhp\\Desktop\\powercher\\imgs\\beer.png";
            pictureBox2.Location = new Point(302, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.ImageLocation = "C:\\Users\\pe04uhp\\Desktop\\powercher\\imgs\\compt.png";
            pictureBox3.Location = new Point(1053, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(94, 81);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.ImageLocation = "C:\\Users\\pe04uhp\\Desktop\\powercher\\imgs\\wallet.png";
            pictureBox4.Location = new Point(1053, 271);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 81);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // wallet
            // 
            wallet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            wallet.AutoSize = true;
            wallet.BackColor = Color.Transparent;
            wallet.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            wallet.Location = new Point(1053, 355);
            wallet.Name = "wallet";
            wallet.Size = new Size(94, 28);
            wallet.TabIndex = 12;
            wallet.Text = "0 PwCs";
            wallet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ups
            // 
            ups.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ups.AutoSize = true;
            ups.BackColor = Color.Transparent;
            ups.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            ups.Location = new Point(1077, 115);
            ups.Name = "ups";
            ups.Size = new Size(46, 28);
            ups.TabIndex = 14;
            ups.Text = "0%";
            ups.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playstation
            // 
            playstation.AutoSize = true;
            playstation.BackColor = Color.Transparent;
            playstation.Location = new Point(260, 533);
            playstation.Name = "playstation";
            playstation.Size = new Size(15, 14);
            playstation.TabIndex = 15;
            playstation.UseVisualStyleBackColor = false;
            playstation.CheckedChanged += playstation_CheckedChanged;
            // 
            // beer
            // 
            beer.AutoSize = true;
            beer.BackColor = Color.Transparent;
            beer.Location = new Point(452, 533);
            beer.Name = "beer";
            beer.Size = new Size(15, 14);
            beer.TabIndex = 16;
            beer.UseVisualStyleBackColor = false;
            // 
            // pompe
            // 
            pompe.AutoSize = true;
            pompe.BackColor = Color.Transparent;
            pompe.Location = new Point(984, 543);
            pompe.Name = "pompe";
            pompe.Size = new Size(15, 14);
            pompe.TabIndex = 18;
            pompe.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.pngtree_thermal_energy_heat_pump_unit_png_png_image_115761822;
            pictureBox5.Location = new Point(698, 373);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(314, 202);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // ups_total
            // 
            ups_total.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ups_total.AutoSize = true;
            ups_total.BackColor = Color.Transparent;
            ups_total.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            ups_total.Location = new Point(547, 182);
            ups_total.Name = "ups_total";
            ups_total.Size = new Size(79, 28);
            ups_total.TabIndex = 20;
            ups_total.Text = "0.0Kw";
            ups_total.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HouseUI_mvc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.chambre;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 636);
            Controls.Add(ups_total);
            Controls.Add(pompe);
            Controls.Add(pictureBox5);
            Controls.Add(beer);
            Controls.Add(playstation);
            Controls.Add(ups);
            Controls.Add(pictureBox4);
            Controls.Add(wallet);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtConsole);
            Controls.Add(pictureBox1);
            Controls.Add(bilan);
            Controls.Add(time);
            Name = "HouseUI_mvc";
            Text = "House";
            Load += HouseUI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label time;
        private Label solde;
        private Label diff;
        private Label bilan;
        private System.Diagnostics.Process process1;
        private PictureBox pictureBox1;
        private RichTextBox txtConsole;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label wallet;
        private Label ups;
        private CheckBox playstation;
        private CheckBox beer;
        private CheckBox pompe;
        private PictureBox pictureBox5;
        private Label ups_total;
    }
}
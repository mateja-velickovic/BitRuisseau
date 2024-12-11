namespace matvelickov_bitRuisseau
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            upload_media = new Button();
            file_dialog = new OpenFileDialog();
            mediaList = new ListBox();
            error_filename = new Label();
            fullscreen_media = new Button();
            showMedia = new PictureBox();
            show_media = new Button();
            delete_media = new Button();
            wMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            txtconsole = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)showMedia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wMediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // upload_media
            // 
            upload_media.BackColor = SystemColors.HotTrack;
            upload_media.FlatAppearance.BorderSize = 0;
            upload_media.FlatStyle = FlatStyle.Flat;
            upload_media.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upload_media.ForeColor = Color.Transparent;
            upload_media.Location = new Point(14, 292);
            upload_media.Margin = new Padding(4, 3, 4, 3);
            upload_media.Name = "upload_media";
            upload_media.Size = new Size(192, 45);
            upload_media.TabIndex = 1;
            upload_media.Text = "Charger un média";
            upload_media.UseVisualStyleBackColor = false;
            upload_media.Click += upload_media_Click;
            // 
            // mediaList
            // 
            mediaList.BackColor = Color.GhostWhite;
            mediaList.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mediaList.ForeColor = SystemColors.HotTrack;
            mediaList.FormattingEnabled = true;
            mediaList.ItemHeight = 22;
            mediaList.Location = new Point(14, 14);
            mediaList.Margin = new Padding(4, 3, 4, 3);
            mediaList.Name = "mediaList";
            mediaList.ScrollAlwaysVisible = true;
            mediaList.Size = new Size(472, 268);
            mediaList.TabIndex = 3;
            mediaList.SelectedIndexChanged += mediaList_SelectedIndexChanged;
            // 
            // error_filename
            // 
            error_filename.AutoSize = true;
            error_filename.BackColor = Color.Transparent;
            error_filename.Font = new Font("Century Gothic", 10F);
            error_filename.ForeColor = Color.Firebrick;
            error_filename.Location = new Point(14, 288);
            error_filename.Margin = new Padding(4, 0, 4, 0);
            error_filename.Name = "error_filename";
            error_filename.Size = new Size(293, 19);
            error_filename.TabIndex = 0;
            error_filename.Text = "Un fichier avec le même nom existe déjà.";
            error_filename.Visible = false;
            // 
            // fullscreen_media
            // 
            fullscreen_media.BackColor = Color.OliveDrab;
            fullscreen_media.BackgroundImage = Properties.Resources.fs;
            fullscreen_media.BackgroundImageLayout = ImageLayout.Zoom;
            fullscreen_media.Cursor = Cursors.Hand;
            fullscreen_media.FlatAppearance.BorderSize = 0;
            fullscreen_media.FlatStyle = FlatStyle.Flat;
            fullscreen_media.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullscreen_media.ForeColor = Color.Transparent;
            fullscreen_media.Location = new Point(370, 288);
            fullscreen_media.Margin = new Padding(4, 3, 4, 3);
            fullscreen_media.Name = "fullscreen_media";
            fullscreen_media.Size = new Size(34, 45);
            fullscreen_media.TabIndex = 8;
            fullscreen_media.UseVisualStyleBackColor = false;
            fullscreen_media.Visible = false;
            fullscreen_media.Click += fullscreen_media_Click;
            // 
            // showMedia
            // 
            showMedia.Location = new Point(14, 343);
            showMedia.Margin = new Padding(4, 3, 4, 3);
            showMedia.Name = "showMedia";
            showMedia.Size = new Size(472, 284);
            showMedia.SizeMode = PictureBoxSizeMode.Zoom;
            showMedia.TabIndex = 6;
            showMedia.TabStop = false;
            showMedia.Visible = false;
            showMedia.Click += showMedia_Click;
            // 
            // show_media
            // 
            show_media.BackColor = SystemColors.HotTrack;
            show_media.BackgroundImage = Properties.Resources.eye;
            show_media.BackgroundImageLayout = ImageLayout.Zoom;
            show_media.Cursor = Cursors.Hand;
            show_media.FlatAppearance.BorderSize = 0;
            show_media.FlatStyle = FlatStyle.Flat;
            show_media.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            show_media.ForeColor = Color.Transparent;
            show_media.Location = new Point(412, 288);
            show_media.Margin = new Padding(4, 3, 4, 3);
            show_media.Name = "show_media";
            show_media.Size = new Size(34, 45);
            show_media.TabIndex = 5;
            show_media.UseVisualStyleBackColor = false;
            show_media.Visible = false;
            show_media.Click += show_media_Click;
            // 
            // delete_media
            // 
            delete_media.BackColor = Color.Maroon;
            delete_media.BackgroundImage = Properties.Resources.corbeille;
            delete_media.BackgroundImageLayout = ImageLayout.Zoom;
            delete_media.Cursor = Cursors.Hand;
            delete_media.FlatAppearance.BorderSize = 0;
            delete_media.FlatStyle = FlatStyle.Flat;
            delete_media.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_media.ForeColor = Color.Transparent;
            delete_media.Location = new Point(452, 288);
            delete_media.Margin = new Padding(4, 3, 4, 3);
            delete_media.Name = "delete_media";
            delete_media.Size = new Size(34, 45);
            delete_media.TabIndex = 4;
            delete_media.UseVisualStyleBackColor = false;
            delete_media.Visible = false;
            delete_media.Click += delete_media_Click;
            // 
            // wMediaPlayer
            // 
            wMediaPlayer.Enabled = true;
            wMediaPlayer.Location = new Point(14, 343);
            wMediaPlayer.Name = "wMediaPlayer";
            wMediaPlayer.OcxState = (AxHost.State)resources.GetObject("wMediaPlayer.OcxState");
            wMediaPlayer.Size = new Size(474, 284);
            wMediaPlayer.TabIndex = 9;
            wMediaPlayer.Visible = false;
            // 
            // txtconsole
            // 
            txtconsole.Location = new Point(493, 14);
            txtconsole.Name = "txtconsole";
            txtconsole.Size = new Size(409, 268);
            txtconsole.TabIndex = 10;
            txtconsole.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(929, 671);
            Controls.Add(txtconsole);
            Controls.Add(wMediaPlayer);
            Controls.Add(fullscreen_media);
            Controls.Add(showMedia);
            Controls.Add(show_media);
            Controls.Add(delete_media);
            Controls.Add(mediaList);
            Controls.Add(upload_media);
            Controls.Add(error_filename);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)showMedia).EndInit();
            ((System.ComponentModel.ISupportInitialize)wMediaPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button upload_media;
        private System.Windows.Forms.OpenFileDialog file_dialog;
        private System.Windows.Forms.ListBox mediaList;
        private System.Windows.Forms.Button delete_media;
        private System.Windows.Forms.Button show_media;
        private System.Windows.Forms.PictureBox showMedia;
        private System.Windows.Forms.Label error_filename;
        private System.Windows.Forms.Button fullscreen_media;
        private AxWMPLib.AxWindowsMediaPlayer wMediaPlayer;
        private RichTextBox txtconsole;
    }
}


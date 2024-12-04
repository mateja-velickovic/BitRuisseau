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
            this.upload_media = new System.Windows.Forms.Button();
            this.file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.mediaList = new System.Windows.Forms.ListBox();
            this.showMedia = new System.Windows.Forms.PictureBox();
            this.show_media = new System.Windows.Forms.Button();
            this.delete_media = new System.Windows.Forms.Button();
            this.wMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.showMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // upload_media
            // 
            this.upload_media.BackColor = System.Drawing.SystemColors.HotTrack;
            this.upload_media.FlatAppearance.BorderSize = 0;
            this.upload_media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_media.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_media.ForeColor = System.Drawing.Color.Transparent;
            this.upload_media.Location = new System.Drawing.Point(12, 264);
            this.upload_media.Name = "upload_media";
            this.upload_media.Size = new System.Drawing.Size(165, 39);
            this.upload_media.TabIndex = 0;
            this.upload_media.Text = "Charger un média";
            this.upload_media.UseVisualStyleBackColor = false;
            this.upload_media.Click += new System.EventHandler(this.upload_media_Click);
            // 
            // mediaList
            // 
            this.mediaList.BackColor = System.Drawing.Color.GhostWhite;
            this.mediaList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaList.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mediaList.FormattingEnabled = true;
            this.mediaList.ItemHeight = 22;
            this.mediaList.Location = new System.Drawing.Point(12, 12);
            this.mediaList.Name = "mediaList";
            this.mediaList.ScrollAlwaysVisible = true;
            this.mediaList.Size = new System.Drawing.Size(359, 246);
            this.mediaList.TabIndex = 3;
            this.mediaList.SelectedIndexChanged += new System.EventHandler(this.mediaList_SelectedIndexChanged);
            // 
            // showMedia
            // 
            this.showMedia.Location = new System.Drawing.Point(386, 12);
            this.showMedia.Name = "showMedia";
            this.showMedia.Size = new System.Drawing.Size(401, 246);
            this.showMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showMedia.TabIndex = 6;
            this.showMedia.TabStop = false;
            this.showMedia.Visible = false;
            // 
            // show_media
            // 
            this.show_media.BackColor = System.Drawing.SystemColors.HotTrack;
            this.show_media.BackgroundImage = global::matvelickov_bitRuisseau.Properties.Resources.eye;
            this.show_media.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_media.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_media.FlatAppearance.BorderSize = 0;
            this.show_media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_media.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_media.ForeColor = System.Drawing.Color.Transparent;
            this.show_media.Location = new System.Drawing.Point(699, 264);
            this.show_media.Name = "show_media";
            this.show_media.Size = new System.Drawing.Size(41, 52);
            this.show_media.TabIndex = 5;
            this.show_media.UseVisualStyleBackColor = false;
            this.show_media.Visible = false;
            this.show_media.Click += new System.EventHandler(this.show_media_Click);
            // 
            // delete_media
            // 
            this.delete_media.BackColor = System.Drawing.Color.Maroon;
            this.delete_media.BackgroundImage = global::matvelickov_bitRuisseau.Properties.Resources.delete;
            this.delete_media.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_media.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_media.FlatAppearance.BorderSize = 0;
            this.delete_media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_media.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_media.ForeColor = System.Drawing.Color.Transparent;
            this.delete_media.Location = new System.Drawing.Point(746, 264);
            this.delete_media.Name = "delete_media";
            this.delete_media.Size = new System.Drawing.Size(41, 52);
            this.delete_media.TabIndex = 4;
            this.delete_media.UseVisualStyleBackColor = false;
            this.delete_media.Visible = false;
            this.delete_media.Click += new System.EventHandler(this.delete_media_Click);
            // 
            // wMediaPlayer
            // 
            this.wMediaPlayer.Enabled = true;
            this.wMediaPlayer.Location = new System.Drawing.Point(387, 12);
            this.wMediaPlayer.Name = "wMediaPlayer";
            this.wMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wMediaPlayer.OcxState")));
            this.wMediaPlayer.Size = new System.Drawing.Size(401, 246);
            this.wMediaPlayer.TabIndex = 7;
            this.wMediaPlayer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.wMediaPlayer);
            this.Controls.Add(this.showMedia);
            this.Controls.Add(this.show_media);
            this.Controls.Add(this.delete_media);
            this.Controls.Add(this.mediaList);
            this.Controls.Add(this.upload_media);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.showMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upload_media;
        private System.Windows.Forms.OpenFileDialog file_dialog;
        private System.Windows.Forms.ListBox mediaList;
        private System.Windows.Forms.Button delete_media;
        private System.Windows.Forms.Button show_media;
        private System.Windows.Forms.PictureBox showMedia;
        private AxWMPLib.AxWindowsMediaPlayer wMediaPlayer;
    }
}


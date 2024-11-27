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
            this.upload_media = new System.Windows.Forms.Button();
            this.file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.media_list = new System.Windows.Forms.ListView();
            this.mediaList = new System.Windows.Forms.ListBox();
            this.delete_media = new System.Windows.Forms.Button();
            this.show_media = new System.Windows.Forms.Button();
            this.showMedia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // upload_media
            // 
            this.upload_media.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_media.Location = new System.Drawing.Point(12, 399);
            this.upload_media.Name = "upload_media";
            this.upload_media.Size = new System.Drawing.Size(145, 39);
            this.upload_media.TabIndex = 0;
            this.upload_media.Text = "Charger un média";
            this.upload_media.UseVisualStyleBackColor = true;
            this.upload_media.Click += new System.EventHandler(this.upload_media_Click);
            // 
            // media_list
            // 
            this.media_list.HideSelection = false;
            this.media_list.Location = new System.Drawing.Point(279, 388);
            this.media_list.Name = "media_list";
            this.media_list.Size = new System.Drawing.Size(233, 30);
            this.media_list.TabIndex = 2;
            this.media_list.UseCompatibleStateImageBehavior = false;
            // 
            // mediaList
            // 
            this.mediaList.FormattingEnabled = true;
            this.mediaList.Location = new System.Drawing.Point(12, 12);
            this.mediaList.Name = "mediaList";
            this.mediaList.Size = new System.Drawing.Size(349, 264);
            this.mediaList.TabIndex = 3;
            this.mediaList.SelectedIndexChanged += new System.EventHandler(this.mediaList_SelectedIndexChanged);
            // 
            // delete_media
            // 
            this.delete_media.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_media.Enabled = false;
            this.delete_media.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_media.Location = new System.Drawing.Point(747, 395);
            this.delete_media.Name = "delete_media";
            this.delete_media.Size = new System.Drawing.Size(41, 39);
            this.delete_media.TabIndex = 4;
            this.delete_media.Text = "x";
            this.delete_media.UseVisualStyleBackColor = true;
            this.delete_media.Click += new System.EventHandler(this.delete_media_Click);
            // 
            // show_media
            // 
            this.show_media.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_media.Enabled = false;
            this.show_media.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_media.Location = new System.Drawing.Point(700, 395);
            this.show_media.Name = "show_media";
            this.show_media.Size = new System.Drawing.Size(41, 39);
            this.show_media.TabIndex = 5;
            this.show_media.Text = "o";
            this.show_media.UseVisualStyleBackColor = true;
            this.show_media.Click += new System.EventHandler(this.show_media_Click);
            // 
            // showMedia
            // 
            this.showMedia.Location = new System.Drawing.Point(386, 12);
            this.showMedia.MaximumSize = new System.Drawing.Size(402, 264);
            this.showMedia.MinimumSize = new System.Drawing.Size(402, 264);
            this.showMedia.Name = "showMedia";
            this.showMedia.Size = new System.Drawing.Size(402, 264);
            this.showMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.showMedia.TabIndex = 6;
            this.showMedia.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showMedia);
            this.Controls.Add(this.show_media);
            this.Controls.Add(this.delete_media);
            this.Controls.Add(this.mediaList);
            this.Controls.Add(this.media_list);
            this.Controls.Add(this.upload_media);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.showMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upload_media;
        private System.Windows.Forms.OpenFileDialog file_dialog;
        private System.Windows.Forms.ListView media_list;
        private System.Windows.Forms.ListBox mediaList;
        private System.Windows.Forms.Button delete_media;
        private System.Windows.Forms.Button show_media;
        private System.Windows.Forms.PictureBox showMedia;
    }
}


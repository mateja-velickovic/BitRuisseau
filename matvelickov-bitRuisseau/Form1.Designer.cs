namespace bit_ruisseau
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtconsole = new RichTextBox();
            file_dialog = new OpenFileDialog();
            error_filename = new Label();
            mediaList = new ListBox();
            wMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            delete_media = new Button();
            show_media = new Button();
            showMedia = new PictureBox();
            fullscreen_media = new Button();
            upload_media = new Button();
            media_available = new ListBox();
            get_online = new Button();
            send_media = new Button();
            ((System.ComponentModel.ISupportInitialize)wMediaPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showMedia).BeginInit();
            SuspendLayout();
            // 
            // txtconsole
            // 
            txtconsole.Location = new Point(492, 12);
            txtconsole.Name = "txtconsole";
            txtconsole.Size = new Size(409, 256);
            txtconsole.TabIndex = 0;
            txtconsole.Text = "";
            // 
            // file_dialog
            // 
            file_dialog.FileName = "openFileDialog1";
            // 
            // error_filename
            // 
            error_filename.AutoSize = true;
            error_filename.ForeColor = Color.Maroon;
            error_filename.Location = new Point(14, 287);
            error_filename.Name = "error_filename";
            error_filename.Size = new Size(234, 15);
            error_filename.TabIndex = 1;
            error_filename.Text = "Un fichier portant le même nom existe déjà";
            error_filename.Visible = false;
            // 
            // mediaList
            // 
            mediaList.Font = new Font("Segoe UI", 14F);
            mediaList.FormattingEnabled = true;
            mediaList.ItemHeight = 25;
            mediaList.Location = new Point(14, 14);
            mediaList.Name = "mediaList";
            mediaList.ScrollAlwaysVisible = true;
            mediaList.Size = new Size(472, 254);
            mediaList.TabIndex = 2;
            mediaList.SelectedIndexChanged += mediaList_SelectedIndexChanged_1;
            // 
            // wMediaPlayer
            // 
            wMediaPlayer.Enabled = true;
            wMediaPlayer.Location = new Point(14, 343);
            wMediaPlayer.Name = "wMediaPlayer";
            wMediaPlayer.OcxState = (AxHost.State)resources.GetObject("wMediaPlayer.OcxState");
            wMediaPlayer.Size = new Size(474, 284);
            wMediaPlayer.TabIndex = 3;
            wMediaPlayer.Visible = false;
            // 
            // delete_media
            // 
            delete_media.BackColor = Color.Maroon;
            delete_media.BackgroundImage = (Image)resources.GetObject("delete_media.BackgroundImage");
            delete_media.BackgroundImageLayout = ImageLayout.Zoom;
            delete_media.FlatAppearance.BorderSize = 0;
            delete_media.FlatStyle = FlatStyle.Flat;
            delete_media.ForeColor = SystemColors.ControlText;
            delete_media.Location = new Point(452, 288);
            delete_media.Name = "delete_media";
            delete_media.Size = new Size(34, 45);
            delete_media.TabIndex = 4;
            delete_media.UseVisualStyleBackColor = false;
            delete_media.Click += delete_media_Click_1;
            // 
            // show_media
            // 
            show_media.BackColor = SystemColors.HotTrack;
            show_media.BackgroundImage = (Image)resources.GetObject("show_media.BackgroundImage");
            show_media.BackgroundImageLayout = ImageLayout.Zoom;
            show_media.FlatAppearance.BorderSize = 0;
            show_media.FlatStyle = FlatStyle.Flat;
            show_media.Location = new Point(412, 288);
            show_media.Name = "show_media";
            show_media.Size = new Size(34, 45);
            show_media.TabIndex = 5;
            show_media.UseVisualStyleBackColor = false;
            show_media.Click += show_media_Click_1;
            // 
            // showMedia
            // 
            showMedia.Location = new Point(14, 343);
            showMedia.Name = "showMedia";
            showMedia.Size = new Size(474, 284);
            showMedia.SizeMode = PictureBoxSizeMode.Zoom;
            showMedia.TabIndex = 6;
            showMedia.TabStop = false;
            showMedia.Visible = false;
            // 
            // fullscreen_media
            // 
            fullscreen_media.BackColor = Color.OliveDrab;
            fullscreen_media.BackgroundImage = (Image)resources.GetObject("fullscreen_media.BackgroundImage");
            fullscreen_media.BackgroundImageLayout = ImageLayout.Zoom;
            fullscreen_media.FlatAppearance.BorderSize = 0;
            fullscreen_media.FlatStyle = FlatStyle.Flat;
            fullscreen_media.Location = new Point(370, 288);
            fullscreen_media.Name = "fullscreen_media";
            fullscreen_media.Size = new Size(34, 45);
            fullscreen_media.TabIndex = 7;
            fullscreen_media.UseVisualStyleBackColor = false;
            // 
            // upload_media
            // 
            upload_media.BackColor = SystemColors.HotTrack;
            upload_media.FlatAppearance.BorderSize = 0;
            upload_media.FlatStyle = FlatStyle.Flat;
            upload_media.Font = new Font("Microsoft Sans Serif", 12.25F);
            upload_media.ForeColor = SystemColors.Control;
            upload_media.Location = new Point(14, 287);
            upload_media.Name = "upload_media";
            upload_media.Size = new Size(192, 45);
            upload_media.TabIndex = 8;
            upload_media.Text = "Charger un media";
            upload_media.UseVisualStyleBackColor = false;
            upload_media.Click += upload_media_Click_1;
            // 
            // media_available
            // 
            media_available.Font = new Font("Segoe UI", 14F);
            media_available.FormattingEnabled = true;
            media_available.ItemHeight = 25;
            media_available.Location = new Point(494, 343);
            media_available.Name = "media_available";
            media_available.ScrollAlwaysVisible = true;
            media_available.Size = new Size(407, 204);
            media_available.TabIndex = 10;
            // 
            // get_online
            // 
            get_online.Location = new Point(735, 578);
            get_online.Name = "get_online";
            get_online.Size = new Size(166, 49);
            get_online.TabIndex = 11;
            get_online.Text = "Demander les appreils disponibles";
            get_online.UseVisualStyleBackColor = true;
            get_online.Click += get_online_Click;
            // 
            // send_media
            // 
            send_media.Location = new Point(494, 578);
            send_media.Name = "send_media";
            send_media.Size = new Size(166, 49);
            send_media.TabIndex = 12;
            send_media.Text = "Envoyer le media qui est affiché";
            send_media.UseVisualStyleBackColor = true;
            send_media.Click += send_media_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(917, 632);
            Controls.Add(send_media);
            Controls.Add(get_online);
            Controls.Add(media_available);
            Controls.Add(upload_media);
            Controls.Add(fullscreen_media);
            Controls.Add(showMedia);
            Controls.Add(show_media);
            Controls.Add(delete_media);
            Controls.Add(wMediaPlayer);
            Controls.Add(mediaList);
            Controls.Add(error_filename);
            Controls.Add(txtconsole);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)wMediaPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)showMedia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtconsole;
        private OpenFileDialog file_dialog;
        private Label error_filename;
        private ListBox mediaList;
        private AxWMPLib.AxWindowsMediaPlayer wMediaPlayer;
        private Button delete_media;
        private Button show_media;
        private PictureBox showMedia;
        private Button fullscreen_media;
        private Button upload_media;
        private ListBox media_available;
        private Button get_online;
        private Button send_media;
    }
}

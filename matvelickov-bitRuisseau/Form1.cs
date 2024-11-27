////////////////////////////////////////////////////////////
///                                                      ///
///     ETML, Vennes                                     ///
///     Author : Velickovic Mateja (matvelickov)         ///
///     Project : P_DEV bit-ruisseau                     ///
///     Date : 06.11.2024                                ///
///                                                      ///
////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace matvelickov_bitRuisseau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Uploading a media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upload_media_Click(object sender, EventArgs e)
        {
            // Applied filters
            file_dialog.Filter = "Images et vidéos (*.MP3;*.MP4;*.MOV;*.GIF;*.PNG;*.JPEG;*.JPG;*.WAV)|*.MP3;*.MP4;*.MOV;*.GIF;*.PNG;*.JPEG;*.JPG;*.WAV|" +
            "All files (*.*)|*.*";

            DialogResult dr = file_dialog.ShowDialog();

            // TODO Check the file's extension
            if (dr == DialogResult.OK)
            {
                UploadMedia();
            }
        }

        /// <summary>
        /// Function which upload the media in the application
        /// </summary>
        public void UploadMedia()
        {
            long file_size_ko = new System.IO.FileInfo(file_dialog.FileName).Length / 1000;
            mediaList.Items.Add($"{file_dialog.SafeFileName} - {file_size_ko}Ko");
        }

        /// <summary>
        /// Return the callback
        /// </summary>
        /// <returns></returns>
        public bool CallBack()
        {
            return false;
        }

        /// <summary>
        /// Deleting the selected media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_media_Click(object sender, EventArgs e)
        {
            if (mediaList.SelectedItem != null)
                mediaList.Items.Remove(mediaList.SelectedItem);
        }

        /// <summary>
        /// Show the selected media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_media_Click(object sender, EventArgs e)
        {
            // TODO Afficher l'image selon l'image sélectionée et pas le file_dialog
            string path = $@"{file_dialog.FileName}";
            string ext = Path.GetExtension(path);

            if (ext == ".mp3")
                showMedia.Image = null;
            else
            {
                showMedia.Image = Image.FromFile(file_dialog.FileName);
                showMedia.Size = new Size(200, 200);
            }
        }

        /// <summary>
        /// Enable the delete and show button when a media's selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_media.Enabled = mediaList.SelectedItem != null;
            show_media.Enabled = mediaList.SelectedItem != null;
        }


    }
}

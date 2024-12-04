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
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace matvelickov_bitRuisseau
{
    public partial class Form1 : Form
    {
        List<Media> listMedia = new List<Media>();

        // List of accepted extensions
        List<string> listExt = new List<string>() { ".mp3", ".mp4", ".mov", ".gif", ".png", ".jpeg", ".jpg", ".wav" };

        List<string> videoExt = new List<string>() { ".mp4", ".mov" };
        List<string> imageExt = new List<string>() { ".gif", ".png", ".jpeg", ".jpg" };
        List<string> audioExt = new List<string>() { ".mp3", ".wav" };

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

            if (dr == DialogResult.OK && listExt.Contains(new System.IO.FileInfo(file_dialog.FileName).Extension))
            {
                UploadMedia();
            }
        }

        /// <summary>
        /// Function which upload the media in the application
        /// </summary>
        public void UploadMedia()
        {
            long file_size = new System.IO.FileInfo(file_dialog.FileName).Length / 1000;
            string file_name = new System.IO.FileInfo(file_dialog.FileName).FullName;

            Media currentMedia = new Media(file_name, file_size);
            listMedia.Add(currentMedia);

            mediaList.Items.Add(new System.IO.FileInfo(currentMedia.Filename).Name);
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
            {
                // TODO Check if the file's sizes are identical
                // TODO Move the original file in the project folder bin/Debug/
                Media currentMedia = listMedia.Single(cm => cm.Filename.Contains(mediaList.SelectedItem.ToString()));

                mediaList.Items.Remove(mediaList.SelectedItem);
                listMedia.Remove(currentMedia);

                showMedia.Image = null;
            }
        }

        /// <summary>
        /// Show the selected media according to its extension
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_media_Click(object sender, EventArgs e)
        {
            // TODO Play music
            // TOOD Play video
            // TODO Check the file's extension
            Media currentMedia = listMedia.Single(cm => cm.Filename.Contains(mediaList.SelectedItem.ToString()));

            string path = $@"{new System.IO.FileInfo(currentMedia.Filename)}";
            string ext = Path.GetExtension(path);

            if(imageExt.Contains(ext))
                showMedia.Image = Image.FromFile(path);
        }

        /// <summary>
        /// Show the selected image
        /// </summary>
        /// <param name="path"></param>
        private void ShowImage(string path)
        {
            showMedia.Image = Image.FromFile(path);
        }

        /// <summary>
        /// Enable the delete and show button when a media's selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_media.Visible = mediaList.SelectedItem != null;
            show_media.Visible = mediaList.SelectedItem != null;
        }
    }
}

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
using System.Linq;
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
            file_dialog.Filter = "Images et vidéos (*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF;*.MP4;*.AVI;*.MKV;*.MOV;*.WMV)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF;*.MP4;*.AVI;*.MKV;*.MOV;*.WMV|" +
            "All files (*.*)|*.*";

            DialogResult dr = file_dialog.ShowDialog();

            // We check if the user uploaded the file
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
            mediaList.Items.Add(file_dialog.SafeFileName);
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
            if(mediaList.SelectedItem != null)
                mediaList.Items.Remove(mediaList.SelectedItem);
        }

        /// <summary>
        /// Enable the delete button when a media's selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mediaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_media.Enabled = mediaList.SelectedItem != null;
        }
    }
}

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
using System.Threading;
using Backend;
using Frontend.Logging;
using Backend.Protocol;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Formatters;
using static System.Net.Mime.MediaTypeNames;

namespace matvelickov_bitRuisseau
{
    public partial class Form1 : Form
    {
        private Mediatheque _mediatheque;
        private Agent _agent;
        private readonly ILogger _logger;

        List<Media> listMedia = new List<Media>();

        List<string> listExt = new List<string>() { ".mp3", ".mp4", ".mov", ".gif", ".png", ".jpeg", ".jpg", ".wav" };

        List<string> videoAudioExt = new List<string>() { ".mp4", ".mov", ".mp3", ".wav" };
        List<string> imageExt = new List<string>() { ".gif", ".png", ".jpeg", ".jpg" };

        public Form1(string broker)
        {
            InitializeComponent();

            var loggerFactory = LoggerFactory.Create(
                builder => builder
                    .AddProvider(new RichTextBoxLoggerProvider(txtconsole))
                    .SetMinimumLevel(LogLevel.Debug)
                );
            _logger = loggerFactory.CreateLogger<Form1>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived);

            _agent.Start();
        }

        private void OnMessageReceived(Envelope envelope)
        {
            switch (envelope.Type)
            {
                case MessageType.HELLO:

                    _logger.LogInformation(envelope.SenderId + "Said Hello");

                    break;
            }
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
            string ext = new System.IO.FileInfo(file_dialog.FileName).Extension;
            MediaTypes file_ext = GetExtension(ext);


            Media currentMedia = new Media(file_name, file_size, file_ext);

            if (!mediaList.Items.Contains(new System.IO.FileInfo(currentMedia.filename).Name))
            {
                error_filename.Visible = false;
                upload_media.Location = new Point(14, 292);

                listMedia.Add(currentMedia);
                mediaList.Items.Add(new System.IO.FileInfo(currentMedia.filename).Name);
                mediaList.SelectedItem = new System.IO.FileInfo(currentMedia.filename).Name;
            }
            else 
            {
                error_filename.Visible = true;
                upload_media.Location = new Point(14, 312);
            }

            // TODO Select the uploaded file on upload
            // TODO Display horizontaly the items
        }

        /// <summary>
        /// Transform the received string into MediaTypes
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static MediaTypes GetExtension(string extension)
        {
            switch (extension)
            {
                case ".mp3":
                    return MediaTypes.MP3;
                case ".mp4":
                    return MediaTypes.MP4;
                case ".mov":
                    return MediaTypes.MOV;
                case ".gif":
                    return MediaTypes.GIF;
                case ".png":
                    return MediaTypes.PNG;
                case ".jpeg":
                    return MediaTypes.JPEG;
                case ".jpg":
                    return MediaTypes.JPG;
                case ".wav":
                    return MediaTypes.WAV;

                default:
                    return MediaTypes.JPG;
            }
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
                Media currentMedia = listMedia.Single(cm => cm.filename.Contains(mediaList.SelectedItem.ToString()));

                mediaList.Items.Remove(mediaList.SelectedItem);
                listMedia.Remove(currentMedia);

                showMedia.Image = null;
                wMediaPlayer.URL = null;
                wMediaPlayer.Visible = false;
            }
        }

        /// <summary>
        /// Show the selected media according to its extension
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_media_Click(object sender, EventArgs e)
        {
            // TODO Check the id of the uploaded the media (duplicates files)
            Media currentMedia = listMedia.Single(cm => cm.filename.Contains(mediaList.SelectedItem.ToString()));

            string path = $@"{new System.IO.FileInfo(currentMedia.filename)}";
            string ext = Path.GetExtension(path);

            if (imageExt.Contains(ext))
                ShowImage(path);
            if (videoAudioExt.Contains(ext))
                ShowVideo(path);
        }

        /// <summary>
        /// Show the selected image
        /// </summary>
        /// <param name="path"></param>
        private void ShowImage(string path)
        {
            wMediaPlayer.Visible = false;
            showMedia.Visible = true;

            showMedia.Image = System.Drawing.Image.FromFile(path);
        }

        /// <summary>
        /// Show the selected video/audio
        /// </summary>
        /// <param name="path"></param>
        private void ShowVideo(string path)
        {
            wMediaPlayer.Visible = true;
            showMedia.Visible = false;

            wMediaPlayer.URL = path;
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
            fullscreen_media.Visible = mediaList.SelectedItem != null;
        }

        private void fullscreen_media_Click(object sender, EventArgs e)
        {


        }

        private void showMedia_Click(object sender, EventArgs e)
        {

        }

    }
}

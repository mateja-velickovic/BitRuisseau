////////////////////////////////////////////////////////////
///                                                      ///
///     ETML, Vennes                                     ///
///     Author : Velickovic Mateja (matvelickov)         ///
///     Project : P_DEV bit-ruisseau                     ///
///     Date : 06.11.2024                                ///
///                                                      ///
////////////////////////////////////////////////////////////

using Backend;
using Backend.Protocol;
using bit_ruisseau.bit_ruisseau;
using Frontend.Logging;
using System.Drawing.Imaging;
using System.Text.Json;

namespace bit_ruisseau
{
    public partial class Form1 : Form
    {
        private Mediatheque _mediatheque;
        private Agent _agent;
        private readonly ILogger _logger;

        List<Media> listMedia = new List<Media>();
        List<MediaContent> listMC = new List<MediaContent>();

        List<string> listExt = new List<string>() { ".mp3", ".mp4", ".mov", ".gif", ".png", ".jpeg", ".jpg", ".wav" };

        List<string> videoAudioExt = new List<string>() { ".mp4", ".mov", ".mp3", ".wav" };
        List<string> imageExt = new List<string>() { ".gif", ".png", ".jpeg", ".jpg" };

        /// <summary>
        /// Main form
        /// </summary>
        /// <param name="broker"></param>
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

        /// <summary>
        /// Receiving messages from the broker
        /// </summary>
        /// <param name="envelope"></param>
        private void OnMessageReceived(Envelope envelope)
        {
            // Ignorer mes propre messages
            if (envelope.SenderId == _agent.NodeId) return;

            _logger.LogInformation(envelope.ToString());

            switch (envelope.Type)
            {
                case MessageType.HELLO:
                    _agent.Send(new Envelope(_agent.NodeId, MessageType.HELLO, "Hello"));
                    break;

                // TODO LWT
                case MessageType.GOOD_BYE:
                    _agent.Send(new Envelope(_agent.NodeId, MessageType.GOOD_BYE, "Bye"));
                    break;

                case MessageType.MEDIA_STATUS:
                    Mediatheque receivedLibrary = JsonSerializer.Deserialize<Mediatheque>(envelope.ToString())!;
                    break;

                case MessageType.MEDIA_STATUS_REQUEST:
                    // Sending the media library when the request is received
                    Mediatheque mateja = new Mediatheque("Mateja !");
                    _agent.Send(new Envelope(_agent.NodeId, MessageType.MEDIA_STATUS, JsonSerializer.Serialize(mateja)));
                    break;

                case MessageType.MEDIA_CONTENT:
                    // Converting the byte array present in the received class into an image
                    MediaContent receivedMedia = JsonSerializer.Deserialize<MediaContent>(envelope.Message)!;
                    Image convertedImage = ByteArrayToImage(receivedMedia.MediaContentFile);

                    // Storing the received class in a list
                    listMC.Add(receivedMedia);
                    media_available.Invoke(new Action(() => media_available.Items.Add($"{receivedMedia.MediathequeName} - {receivedMedia.FileName}")));
                    break;

                case MessageType.MEDIA_CONTENT_REQUEST:
                    // Sending the displayed image, to the broker
                    MediaContent sentMedia = new MediaContent([2, 2], "Mateja", "test.txt", false);
                    _agent.Send(new Envelope(_agent.NodeId, MessageType.MEDIA_CONTENT, JsonSerializer.Serialize(sentMedia)));
                    break;
            }
        }

        /// <summary>
        /// Uploading a media
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upload_media_Click_1(object sender, EventArgs e)
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

            if (!mediaList.Items.Contains(new System.IO.FileInfo(currentMedia.FileName).Name))
            {
                error_filename.Visible = false;
                upload_media.Location = new Point(14, 292);

                listMedia.Add(currentMedia);
                mediaList.Items.Add(new System.IO.FileInfo(currentMedia.FileName).Name);
                mediaList.SelectedItem = new System.IO.FileInfo(currentMedia.FileName).Name;
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
        /// Convert an image to a byte's array
        /// </summary>
        /// <param name="imageToByte"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image imageToByte)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] bytes = (byte[])_imageConverter.ConvertTo(imageToByte, typeof(byte[]));
            return bytes;
        }

        /// <summary>
        /// Convert a byte's array to image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            Image imageBack = Image.FromStream(ms, true);
            return imageBack;
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
        private void delete_media_Click_1(object sender, EventArgs e)
        {
            if (mediaList.SelectedItem != null)
            {
                // TODO Check if the file's sizes are identical
                // TODO Move the original file in the project folder bin/Debug/
                Media currentMedia = listMedia.Single(cm => cm.FileName.Contains(mediaList.SelectedItem.ToString()));

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
        private void show_media_Click_1(object sender, EventArgs e)
        {
            // TODO Check the id of the uploaded the media (duplicates files)
            Media currentMedia = listMedia.Single(cm => cm.FileName.Contains(mediaList.SelectedItem.ToString()));

            string path = $@"{new System.IO.FileInfo(currentMedia.FileName)}";
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
        private void mediaList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            delete_media.Visible = mediaList.SelectedItem != null;
            show_media.Visible = mediaList.SelectedItem != null;
            fullscreen_media.Visible = mediaList.SelectedItem != null;
        }

        /// <summary>
        /// Ask the broker what media are present
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void get_online_Click(object sender, EventArgs e)
        {
            _agent.Send(new Envelope(_agent.NodeId, MessageType.MEDIA_STATUS_REQUEST, ""));
        }

        /// <summary>
        /// Sending a MediaContent to the broker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void send_media_Click(object sender, EventArgs e)
        {
            MediaContent myMedia = new MediaContent(ImageToByteArray(showMedia.Image), "Mateja", "mateja.png", false);
            _agent.Send(new Envelope(_agent.NodeId, MessageType.MEDIA_CONTENT, JsonSerializer.Serialize(ImageToByteArray(showMedia.Image))));
        }

    }
}

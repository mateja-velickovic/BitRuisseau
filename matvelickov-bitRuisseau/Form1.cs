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
            Image.GetThumbnailImageAbort cb = new Image.GetThumbnailImageAbort(CallBack);
            Bitmap bm = new Bitmap(file_dialog.FileName);

            // Setting the final picture
            Image final_picture = bm.GetThumbnailImage(300, 300, cb, IntPtr.Zero);
            imageList1.Images.Add(final_picture);
            media_list.Items.Add(file_dialog.SafeFileName);

            Graphics theGraphics = Graphics.FromHwnd(this.Handle);

            for (int c = 0; c < imageList1.Images.Count; ++c)
            {
                try
                {
                    imageList1.Draw(theGraphics, new Point(85, 85 * c / 2), c);
                }
                catch (DivideByZeroException)
                {
                    imageList1.Draw(theGraphics, new Point(85, 85 * c), c);
                }

                Application.DoEvents();

                System.Threading.Thread.Sleep(300);
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

    }
}

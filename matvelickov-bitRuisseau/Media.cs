using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matvelickov_bitRuisseau
{
    /// <summary>
    /// 
    /// </summary>
    public class Media
    {
        public Media(string filename, long size, MediaTypes mediaType)
        {
            this.filename = filename;

            this.size = size / 1024;

            this.mediaType = mediaType;
        }

        public string filename { get; set; }
        public long size { get; set; } // Taille du fichier en Octets

        public MediaTypes mediaType { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matvelickov_bitRuisseau
{
    public class Media
    {
        public string Filename;
        public long Size;

        public Media(string filename, long size)
        {
            Filename = filename; 
            Size = size;
        }

        enum MediaType
        {
            MP3,
            MP4,
            MOV,
            GIF,
            PNG,
            JPEG,
            JPG,
            WAV
        }
    }
}

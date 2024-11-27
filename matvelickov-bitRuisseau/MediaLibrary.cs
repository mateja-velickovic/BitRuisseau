using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matvelickov_bitRuisseau
{
    public class MediaLibrary
    {
        bool isAvailable;
        string DisplayName;
        List<Media> Medias;

        public MediaLibrary(bool isAvailable, string displayName, List<Media> medias)
        {
            this.isAvailable = isAvailable;
            DisplayName = displayName;
            Medias = medias;
        }
    }
}

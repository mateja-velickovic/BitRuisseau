namespace bit_ruisseau
{
    public class Media
    {
        public Media(string filename, long size, MediaTypes mediaType)
        {
            this.FileName = filename;

            this.size = size / 1024;

            this.mediaType = mediaType;
        }
        public string FileName { get; set; }
        public long size { get; set; } // Taille du fichier en Octets

        public MediaTypes mediaType { get; set; }

    }
}
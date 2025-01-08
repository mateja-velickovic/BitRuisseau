namespace bit_ruisseau
{

    namespace bit_ruisseau
    {
        public class MediaContent
        {
            public byte[] MediaContentFile { get; set; }
            public string MediathequeName { get; set; }
            public string FileName { get; set; }
            public bool Request { get; set; }

            public MediaContent(byte[] mediaContentFile, string mediathequeName, string fileName, bool request)
            {
                MediaContentFile = mediaContentFile;
                MediathequeName = mediathequeName;
                FileName = fileName;
                Request = request;
            }
        }
    }
}

using System.Collections.Generic;

namespace MusicViewer.MusicFileProperties
{
    internal class Track : FileItem
    {
        public int CodeIdAlbum { get; set; }

        public int CodeIdArtist { get; set; }

        public List<int> CodeIdGenre { get; } = new List<int>();
        
        public string DateOfRelease { get; set; }

        public string SongLength { get; set; }       
    }
}
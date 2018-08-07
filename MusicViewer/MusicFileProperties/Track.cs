using System.Collections.Generic;

namespace MusicViewer.MusicFileProperties
{
    internal class Track : FileItem
    {
        public List<int> CodeIdGenre { get; } = new List<int>();

        public int CodeIdAlbum { get; set; }

        public int CodeIdArtist { get; set; }

        public string SongLength { get; set; }

        public string DateOfRelease { get; set; }
    }
}
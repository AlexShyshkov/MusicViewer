using System.Collections.Generic;

namespace MusicViewer.MusicFileProperties
{
    internal class Track : FileItem
    {
        public List<int> codeIdGenre { get; } = new List<int>();

        public int codeIdAlbum { get; set; }

        public int codeIdArtist { get; set; }

        public string SongLength { get; set; }

        public string DateOfRelease { get; set; }
    }
}
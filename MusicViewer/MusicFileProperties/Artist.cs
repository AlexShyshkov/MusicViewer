using System.Collections.Generic;

namespace MusicViewer.MusicFileProperties
{
    internal class Artist : FileItem
    {
        public ICollection<Artist> Artists { get; } = new List<Artist>();
    }
}
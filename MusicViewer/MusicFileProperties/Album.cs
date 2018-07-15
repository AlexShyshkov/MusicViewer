using System.Collections.Generic;

namespace MusicViewer.MusicFileProperties
{
    internal class Album : FileItem
    {
        public ICollection<Album> Albums { get; } = new List<Album>();
    }
}
using System.Collections.Generic;

namespace MusicViewer.MusicFileProperties
{
    internal class Genre : FileItem
    {
        public ICollection<Genre> Genres { get; } = new List<Genre>();
    }
}
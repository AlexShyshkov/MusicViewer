namespace MusicViewer.MusicFileProperties
{
    internal class FileItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
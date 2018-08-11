using MusicViewer.MusicFileProperties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace MusicViewer
{
    public partial class MainForm : Form
    {
        private IEnumerable<Album> albums;
        private IEnumerable<Artist> artists;
        private IEnumerable<Genre> genres;
        private IEnumerable<Track> tracks;

        private DateTime endDate;
        private DateTime startDate;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearMusicInfo();
                MusicViewerListBox.Items.Clear();
                LoadFile(openFileDialog.FileName);
                foreach (var artist in artists)
                {
                    ComboBoxSelect.Items.Add(artist);
                }
            }
        }

        private void ComboBoxSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            MusicViewerListBox.Items.Clear();
            ClearMusicInfo();
            startDate = DateTime.MaxValue;
            endDate = DateTime.MinValue;

            foreach (var track in tracks)
            {
                foreach (var artist in artists)
                {
                    if (ComboBoxSelect.Text == artist.Name && track.CodeIdArtist == artist.Id)
                    {
                        MusicViewerListBox.Items.Add(track);

                        if (DateTime.Parse(track.DateOfRelease) < startDate)
                        {
                            startDate = DateTime.Parse(track.DateOfRelease);
                        }

                        if (DateTime.Parse(track.DateOfRelease) > endDate)
                        {
                            endDate = DateTime.Parse(track.DateOfRelease);
                        }
                    }
                }
            }
            DateTimePickerFrom.Value = startDate;
            DateTimePickerTo.Value = endDate;
        }

        private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePickerFrom.Value < startDate || DateTimePickerFrom.Value > DateTimePickerTo.Value)
            {
                DateTimePickerFrom.Value = startDate;
            }
        }

        private void DateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePickerTo.Value > endDate || DateTimePickerTo.Value < DateTimePickerFrom.Value)
            {
                DateTimePickerTo.Value = endDate;
            }
        }

        private void MusicViewerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMusicInfo();
            foreach (var track in tracks)
            {
                if (MusicViewerListBox.SelectedItem != null && MusicViewerListBox.SelectedItem.ToString() == track.Name)
                {
                    foreach (var artist in artists)
                    {
                        if (track.CodeIdArtist == artist.Id)
                        {
                            foreach (var album in albums)
                            {
                                if (track.CodeIdAlbum == album.Id)
                                {
                                    textBoxAlbum.Text = album.Name;
                                    break;
                                }
                            }
                            textBoxReleased.Text = DateTime.Parse(track.DateOfRelease).ToString("d MMMM yyyy");
                            textBoxLength.Text = track.SongLength.ToString();

                            List<string> Genres = new List<string>();
                            foreach (var genre in genres)
                            {
                                foreach (var trackGenre in track.CodeIdGenre)
                                {
                                    if (genre.Id == trackGenre)
                                    {
                                        textBoxGenres.Text = genre.Name;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                }
            }
        } 
        
        public void ClearMusicInfo()
        {
            textBoxAlbum.Clear();
            textBoxGenres.Clear();
            textBoxReleased.Clear();
            textBoxLength.Clear();
        }

        private void LoadFile(string fileName)
        {
            var albumFromFile = new List<Album>();
            var artistFromFile = new List<Artist>();
            var genreFromFile = new List<Genre>();
            var trackFromFile = new List<Track>();

            using (XmlReader reader = XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "album")
                        {
                            var album = new Album
                            {
                                Id = int.Parse(reader.GetAttribute("id")),
                                Name = reader.GetAttribute("name")
                            };
                            albumFromFile.Add(album);
                        }
                        else if (reader.Name == "artist")
                        {
                            var artist = new Artist
                            {
                                Id = int.Parse(reader.GetAttribute("id")),
                                Name = reader.GetAttribute("name")
                            };
                            artistFromFile.Add(artist);
                        }
                        else if (reader.Name == "genre")
                        {
                            var genre = new Genre
                            {
                                Id = int.Parse(reader.GetAttribute("id")),
                                Name = reader.GetAttribute("name")
                            };
                            genreFromFile.Add(genre);
                        }
                        else if (reader.Name == "track")
                        {
                            var track = new Track
                            {
                                CodeIdAlbum = int.Parse(reader.GetAttribute("album-id")),
                                CodeIdArtist = int.Parse(reader.GetAttribute("artist-id")),
                                SongLength = DateTime.Parse(reader.GetAttribute("length")).ToShortTimeString(),
                                Name = reader.GetAttribute("name"),
                                Id = int.Parse(reader.GetAttribute("number")),
                                DateOfRelease = DateTime.Parse(reader.GetAttribute("released")).Date.ToLongDateString(),
                            };

                            reader.Read();
                            reader.Read();
                            reader.Read();

                            while (reader.IsStartElement("genre"))
                            {
                                track.CodeIdGenre.Add(int.Parse(reader.GetAttribute("genre-id")));
                                reader.Read();
                            }
                            trackFromFile.Add(track);
                        }
                    }
                }
                albums = albumFromFile;
                artists = artistFromFile;
                genres = genreFromFile;
                tracks = trackFromFile;
            }
        }   
    }
}
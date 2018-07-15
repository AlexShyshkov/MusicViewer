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

        private DateTime startDate;
        private DateTime endDate;

        public MainForm()
        {
            InitializeComponent();
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
                                codeIdAlbum = int.Parse(reader.GetAttribute("album-id")),
                                codeIdArtist = int.Parse(reader.GetAttribute("artist-id")),
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
                                track.codeIdGenre.Add(int.Parse(reader.GetAttribute("genre-id")));
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
        

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearMusicInfo();
                musicViewerListBox.Items.Clear();
                LoadFile(openFileDialog.FileName);
                foreach(var artist in artists)
                {
                    comboBoxSelect.Items.Add(artist);
                }
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value < startDate || dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                dateTimePickerFrom.Value = startDate;
            }
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerTo.Value > endDate || dateTimePickerTo.Value <dateTimePickerFrom.Value)
            {
                dateTimePickerTo.Value = endDate;
            }
        }

        private void musicViewerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearMusicInfo();
            foreach (var track in tracks)
            {
                if (musicViewerListBox.SelectedItem != null && musicViewerListBox.SelectedItem.ToString() == track.Name)
                {
                    foreach (var artist in artists)
                    {
                        if (track.codeIdArtist == artist.Id)
                        {
                            foreach (var album in albums)
                            {
                                if (track.codeIdAlbum == album.Id)
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
                                foreach (var trackGenre in track.codeIdGenre)
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

        private void comboBoxSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            musicViewerListBox.Items.Clear();
            ClearMusicInfo();
            startDate = DateTime.MaxValue;
            endDate = DateTime.MinValue;

            foreach (var track in tracks)
            {
                foreach (var artist in artists)
                {
                    if (comboBoxSelect.Text == artist.Name && track.codeIdArtist == artist.Id)
                    {
                        musicViewerListBox.Items.Add(track);

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
            dateTimePickerFrom.Value = startDate;
            dateTimePickerTo.Value = endDate;
        }
    }
}
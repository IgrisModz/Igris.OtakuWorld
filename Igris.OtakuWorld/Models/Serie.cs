using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Igris.OtakuWorld.Creation.Models
{
    public enum SerieType
    {
        Manga,
        Novel,
    }

    public enum SerieState
    {
        Canceled,
        OnGoing,
        Completed,
        Editing
    }

    public class Serie
    {
        public int Id { get; set; }
        public BitmapImage Cover { get; set; } = new BitmapImage();
        public string Name { get; set; } = string.Empty;
        public string AlternativeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public SerieType Type { get; set; }
        public SerieState State { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public List<Chapter> Chapters { get; set; } = new List<Chapter>();
        public DateTime ReleaseDate { get; set; }
        public DateTime LastCustomDate { get; set; }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(Name) ? Name : Id.ToString();
        }
    }
}

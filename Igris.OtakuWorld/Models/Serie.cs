using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Igris.OtakuWorld.Creation.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public BitmapImage Cover { get; set; } = new BitmapImage();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public List<Chapter> Chapters { get; set; } = new List<Chapter>();
        public DateTime ReleaseDate { get; set; }
        public DateTime LastCustomDate { get; set; }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(Name) ? Name: Id.ToString();
        }
    }
}

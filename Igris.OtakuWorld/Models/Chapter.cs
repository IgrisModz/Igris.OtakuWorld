using System;

namespace Igris.OtakuWorld.Creation.Models
{
    public class Chapter
    {
        public float Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public DateTime LastCustomDate { get; set; }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(Name) ? $"Chapter {Id}: {Name}" : $"Chapter {Id}";
        }
    }
}

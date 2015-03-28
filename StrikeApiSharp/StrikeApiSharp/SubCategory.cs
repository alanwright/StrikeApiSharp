// ****************************************
// Assembly : NetflixRouletteSharp
// File     : Subcategory.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikeApiSharp
{
    public sealed class Subcategory : IComparable<Subcategory>
    {
        #region Static Constructor

        static Subcategory()
        {
            Subcategories = new List<Subcategory>
            {
                new Subcategory("Highres Movies"),
                new Subcategory("Hentai"),
                new Subcategory("HD Video"),
                new Subcategory("Handheld"),
                new Subcategory("Games"),
                new Subcategory("Fiction"),
                new Subcategory("English-translated"),
                new Subcategory("Ebooks"),
                new Subcategory("Dubbed Movies"),
                new Subcategory("Documentary"),
                new Subcategory("Concerts"),
                new Subcategory("Comics"),
                new Subcategory("Books"),
                new Subcategory("Bollywood"),
                new Subcategory("Audio books"),
                new Subcategory("Asian"),
                new Subcategory("Anime Music Video"),
                new Subcategory("Animation"),
                new Subcategory("Android"),
                new Subcategory("Academic"),
                new Subcategory("AAC"),
                new Subcategory("3D Movies"),
                new Subcategory("XBOX360"),
                new Subcategory("Windows"),
                new Subcategory("Wii"),
                new Subcategory("Wallpapers"),
                new Subcategory("Video"),
                new Subcategory("Unsorted"),
                new Subcategory("UNIX"),
                new Subcategory("UltraHD"),
                new Subcategory("Tutorials"),
                new Subcategory("Transcode"),
                new Subcategory("Trailer"),
                new Subcategory("Textbooks"),
                new Subcategory("Subtitles"),
                new Subcategory("Soundtrack"),
                new Subcategory("Sound clips"),
                new Subcategory("Radio Shows"),
                new Subcategory("PSP"),
                new Subcategory("PS3"),
                new Subcategory("PS2"),
                new Subcategory("Poetry"),
                new Subcategory("Pictures"),
                new Subcategory("PC"),
                new Subcategory("Other XXX"),
                new Subcategory("Other TV"),
                new Subcategory("Other Music"),
                new Subcategory("Other Movies"),
                new Subcategory("Other Games"),
                new Subcategory("Other Books"),
                new Subcategory("Other Applications"),
                new Subcategory("Other Anime"),
                new Subcategory("Non-fiction"),
                new Subcategory("Newspapers"),
                new Subcategory("Music videos"),
                new Subcategory("Mp3"),
                new Subcategory("Movie clips"),
                new Subcategory("Magazines"),
                new Subcategory("Mac"),
                new Subcategory("Lossless"),
                new Subcategory("Linux"),
                new Subcategory("Karaoke"),
                new Subcategory("iOS"),
            };
        }

        #endregion

        /// <summary>
        /// Creates a new Subcategory.
        /// </summary>
        /// <param name="name">The name of the subcategory</param>
        public Subcategory(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        // Initialized in static constructor
        private static List<Subcategory> Subcategories;

        public int CompareTo(Subcategory other)
        {
            return other != null ? string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase) : 0;
        }

        public List<Subcategory> GetSubCategories()
        {
            return Subcategories;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

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
        /// <summary>
        /// Creates a new Subcategory.
        /// </summary>
        /// <param name="name">The name of the subcategory</param>
        public Subcategory(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public int CompareTo(Subcategory other)
        {
            return other != null ? string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase) : 0;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    #region Hard-Coded Subcategories

    public static class Subcategories
    {
        public static Subcategory HighresMovies { get { return new Subcategory("Highres Movies"); } }
        public static Subcategory Hentai { get { return new Subcategory("Hentai"); } }
        public static Subcategory HdVideo { get { return new Subcategory("HD Video"); } }
        public static Subcategory Handheld { get { return new Subcategory("Handheld"); } }
        public static Subcategory Games { get { return new Subcategory("Games"); } }
        public static Subcategory Fiction { get { return new Subcategory("Fiction"); } }
        public static Subcategory EnglishTranslated { get { return new Subcategory("English-translated"); } }
        public static Subcategory Ebooks { get { return new Subcategory("Ebooks"); } }
        public static Subcategory DubbedMovies { get { return new Subcategory("Dubbed Movies"); } }
        public static Subcategory Documentary { get { return new Subcategory("Documentary"); } }
        public static Subcategory Concerts { get { return new Subcategory("Concerts"); } }
        public static Subcategory Comics { get { return new Subcategory("Comics"); } }
        public static Subcategory Books { get { return new Subcategory("Books"); } }
        public static Subcategory Bollywood { get { return new Subcategory("Bollywood"); } }
        public static Subcategory AudioBooks { get { return new Subcategory("Audio books"); } }
        public static Subcategory Asian { get { return new Subcategory("Asian"); } }
        public static Subcategory AnimeMusicVideo { get { return new Subcategory("Anime Music Video"); } }
        public static Subcategory Animation { get { return new Subcategory("Animation"); } }
        public static Subcategory Android { get { return new Subcategory("Android"); } }
        public static Subcategory Academic { get { return new Subcategory("Academic"); } }
        public static Subcategory AAC { get { return new Subcategory("AAC"); } }
        public static Subcategory Movies3d { get { return new Subcategory("3D Movies"); } }
        public static Subcategory XBOX360 { get { return new Subcategory("XBOX360"); } }
        public static Subcategory Windows { get { return new Subcategory("Windows"); } }
        public static Subcategory Wii { get { return new Subcategory("Wii"); } }
        public static Subcategory Wallpapers { get { return new Subcategory("Wallpapers"); } }
        public static Subcategory Video { get { return new Subcategory("Video"); } }
        public static Subcategory Unsorted { get { return new Subcategory("Unsorted"); } }
        public static Subcategory UNIX { get { return new Subcategory("UNIX"); } }
        public static Subcategory UltraHD { get { return new Subcategory("UltraHD"); } }
        public static Subcategory Tutorials { get { return new Subcategory("Tutorials"); } }
        public static Subcategory Transcode { get { return new Subcategory("Transcode"); } }
        public static Subcategory Trailer { get { return new Subcategory("Trailer"); } }
        public static Subcategory Textbooks { get { return new Subcategory("Textbooks"); } }
        public static Subcategory Subtitles { get { return new Subcategory("Subtitles"); } }
        public static Subcategory Soundtrack { get { return new Subcategory("Soundtrack"); } }
        public static Subcategory SoundClips { get { return new Subcategory("Sound clips"); } }
        public static Subcategory RadioShows { get { return new Subcategory("Radio Shows"); } }
        public static Subcategory Psp { get { return new Subcategory("PSP"); } }
        public static Subcategory Ps3 { get { return new Subcategory("PS3"); } }
        public static Subcategory Ps2 { get { return new Subcategory("PS2"); } }
        public static Subcategory Poetry { get { return new Subcategory("Poetry"); } }
        public static Subcategory Pictures { get { return new Subcategory("Pictures"); } }
        public static Subcategory Pc { get { return new Subcategory("PC"); } }
        public static Subcategory OtherXxx { get { return new Subcategory("Other XXX"); } }
        public static Subcategory OtherTv { get { return new Subcategory("Other TV"); } }
        public static Subcategory OtherMusic { get { return new Subcategory("Other Music"); } }
        public static Subcategory OtherMovies { get { return new Subcategory("Other Movies"); } }
        public static Subcategory OtherGames { get { return new Subcategory("Other Games"); } }
        public static Subcategory OtherBooks { get { return new Subcategory("Other Books"); } }
        public static Subcategory OtherApplications { get { return new Subcategory("Other Applications"); } }
        public static Subcategory OtherAnime { get { return new Subcategory("Other Anime"); } }
        public static Subcategory NonFiction { get { return new Subcategory("Non-fiction"); } }
        public static Subcategory Newspapers { get { return new Subcategory("Newspapers"); } }
        public static Subcategory MusicVideos { get { return new Subcategory("Music videos"); } }
        public static Subcategory Mp3 { get { return new Subcategory("Mp3"); } }
        public static Subcategory MovieClips { get { return new Subcategory("Movie clips"); } }
        public static Subcategory Magazines { get { return new Subcategory("Magazines"); } }
        public static Subcategory Mac { get { return new Subcategory("Mac"); } }
        public static Subcategory Lossless { get { return new Subcategory("Lossless"); } }
        public static Subcategory Linux { get { return new Subcategory("Linux"); } }
        public static Subcategory Karaoke { get { return new Subcategory("Karaoke"); } }
        public static Subcategory iOS { get { return new Subcategory("iOS"); } }
    }

    #endregion
}

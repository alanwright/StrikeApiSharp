// ****************************************
// Assembly : NetflixRouletteSharp
// File     : StrikeApiSharp.cs
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
    public static class StrikeApi
    {
        private const string BaseApiUrl = "https://getstrike.net/api/v2/torrents/";
        private const int MaxListLength = 50;

        /// <summary>
        /// Gets torrent info for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent</param>
        public static void GetTorrent(string hash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets torrent info for a given list of torrent hashes.
        /// </summary>
        /// <param name="hashes">A list of string hash representing the torrents</param>
        /// <remarks>Limited to 50 per query</remarks>
        public static void GetTorrents(List<string> hashes)
        {
            // TODO: Define custom exception.
            if (hashes.Count > MaxListLength)
                throw new Exception();

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the description for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent</param>
        public static void GetTorrentDescription(string hash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the descriptions for the list of given torrent hashes.
        /// </summary>
        /// <param name="hashes">A list of string hash representing the torrents</param>
        /// <remarks>Limited to 50 per query</remarks>
        public static void GetTorrentDescriptions(List<string> hashes)
        {
            // TODO: Define custom exception.
            if (hashes.Count > MaxListLength)
                throw new Exception();

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a download url for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent</param>
        public static void GetTorrentDownloadUrl(string hash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the total number of indexed torrents.
        /// </summary>
        public static void GetTorrentCount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches torrents using the given phrase.
        /// </summary>
        /// <param name="phrase">A search phrase</param>
        /// <remarks>Returns a maximum of 100 results</remarks>
        public static void SearchTorrents(string phrase)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches torrents using the given phrase, and subcategory.
        /// </summary>
        /// <param name="phrase">A search phrase</param>
        /// <param name="category">A <see cref="Category"/></param>
        public static void SearchTorrents(string phrase, Category category)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches torrents using the given phrase, category and subcategory.
        /// </summary>
        /// <param name="phrase">A search phrase</param>
        /// <param name="category">A <see cref="Category"/></param>
        /// <param name="subcategory">A <see cref="Subcategory"/></param>
        public static void SearchTorrents(string phrase, Category category, Subcategory subcategory)
        {
            throw new NotImplementedException();
        }
    }
}

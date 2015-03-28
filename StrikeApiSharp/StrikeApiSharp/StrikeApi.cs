// ****************************************
// Assembly : NetflixRouletteSharp
// File     : StrikeApiSharp.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikeApiSharp
{
    public class StrikeApi
    {
        private const string BaseApiUrl = "https://getstrike.net/api/v2/";
        private const int MaxListLength = 50;

        private readonly RestClient _client;

        public StrikeApi()
        {
            _client = new RestClient(BaseApiUrl);
        }

        private IRestResponse<T> Execute<T>(IRestRequest request) where T : new()
        {
            var response = _client.Execute<T>(request);

            if (response.ErrorException != null)
                throw response.ErrorException;

            return response;
        }

        /// <summary>
        /// Gets torrent info for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent</param>
        public void GetTorrent(string hash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets torrent info for a given list of torrent hashes.
        /// </summary>
        /// <param name="hashes">A list of string hash representing the torrents</param>
        /// <remarks>Limited to 50 per query</remarks>
        public void GetTorrents(List<string> hashes)
        {
            var trimmedHashes = hashes.Take(MaxListLength);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the description for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent</param>
        public void GetTorrentDescription(string hash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the descriptions for the list of given torrent hashes.
        /// </summary>
        /// <param name="hashes">A list of string hash representing the torrents</param>
        /// <remarks>Limited to 50 per query</remarks>
        public void GetTorrentDescriptions(List<string> hashes)
        {
            var trimmedHashes = hashes.Take(MaxListLength);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a download url for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent</param>
        public void GetTorrentDownloadUrl(string hash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the total number of indexed torrents.
        /// </summary>
        public void GetTorrentCount()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches torrents using the given phrase, category and subcategory.
        /// </summary>
        /// <param name="phrase">A search phrase</param>
        /// <param name="category">A <see cref="Category"/></param>
        /// <param name="subcategory">A <see cref="Subcategory"/></param>
        public void SearchTorrents(string phrase, Category category = null, Subcategory subcategory = null)
        {
            // TODO: Check category/subcategory for null
            throw new NotImplementedException();
        }
    }
}

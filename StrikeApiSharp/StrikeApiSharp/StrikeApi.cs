// ****************************************
// Assembly : NetflixRouletteSharp
// File     : StrikeApi.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using RestSharp;
using StrikeApiSharp.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

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
        public TorrentInfoResponse GetTorrent(string hash)
        {
            if (string.IsNullOrEmpty(hash))
                throw new ArgumentNullException("hash");

            return GetTorrents(new List<string>{ hash }).FirstOrDefault();
        }

        /// <summary>
        /// Gets torrent info for a given list of torrent hashes.
        /// </summary>
        /// <param name="hashes">A list of string hash representing the torrents</param>
        /// <remarks>Limited to 50 per query</remarks>
        public List<TorrentInfoResponse> GetTorrents(List<string> hashes)
        {
            var trimmedHashes = hashes.Take(MaxListLength);

            var request = new RestRequest("torrents/info/", Method.GET);
            request.AddParameter("hashes", string.Join(",", trimmedHashes));

            var response = Execute<TorrentInfoResponses>(request);

            if (response.StatusCode != HttpStatusCode.OK || response.Data == null)
                return new List<TorrentInfoResponse>();

            return response.Data.Torrents;
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
        /// <returns>The total number of indexed torrents.</returns>
        public long GetTorrentCount()
        {
            var request = new RestRequest("torrents/count/", Method.GET);
            var response = Execute<TorrentCountResponses>(request);

            if (response.StatusCode != HttpStatusCode.OK || response.Data == null)
                return 0;

            return response.Data.Count;
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

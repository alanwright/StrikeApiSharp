// ****************************************
// Assembly : StrikeApiSharp
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
                throw response.ErrorException; // TODO: are you sure you want to do this?

            return response;
        }

        /// <summary>
        /// Gets torrent info for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent.</param>
        /// <returns>A <see cref="TorrentInfoResponse"/>.</returns>
        public TorrentInfoResponse GetTorrent(string hash)
        {
            if (string.IsNullOrEmpty(hash))
                throw new ArgumentNullException("hash");

            return GetTorrents(new List<string>{ hash }).FirstOrDefault();
        }

        /// <summary>
        /// Gets torrent info for a given list of torrent hashes.
        /// </summary>
        /// <param name="hashes">A list of string hash representing the torrents.</param>
        /// <remarks>Limited to 50 per query.</remarks>
        /// <returns>A list of <see cref="TorrentInfoResponse"/>.</returns>
        public List<TorrentInfoResponse> GetTorrents(List<string> hashes)
        {
            var trimmedHashes = hashes.Take(MaxListLength);

            var request = new RestRequest("torrents/info/", Method.GET);
            request.AddParameter("hashes", string.Join(",", trimmedHashes));

            var response = Execute<TorrentInfoResponses>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.Data == null)
                return new List<TorrentInfoResponse>(); // TODO: throw an exception?

            return response.Data.Torrents;
        }

        /// <summary>
        /// Gets the description for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent.</param>
        /// <returns>The description for provided torrent hash.</returns>
        public string GetTorrentDescription(string hash)
        {
            if (string.IsNullOrEmpty(hash))
                throw new ArgumentNullException(hash);

            var request = new RestRequest("torrents/descriptions/", Method.GET);
            request.AddParameter("hash", hash);

            var response = Execute<TorrentDescriptionResponse>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.Data == null)
                return null; // TODO: throw an exception?

            return response.Data.Description;
        }

        /// <summary>
        /// Gets the descriptions for the list of given torrent hashes.
        /// </summary>
        /// <param name="hashes">A list of string hash representing the torrents.</param>
        /// <remarks>Limited to 50 per query.</remarks>
        public void GetTorrentDescriptions(List<string> hashes)
        {
            var trimmedHashes = hashes.Take(MaxListLength);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a download url for the given torrent hash.
        /// </summary>
        /// <param name="hash">A string hash representing the torrent.</param>
        /// <returns>The torrent download URL in the form of a string.</returns>
        public string GetTorrentDownloadUrl(string hash)
        {
            if (string.IsNullOrEmpty(hash))
                throw new ArgumentNullException(hash);

            var request = new RestRequest("torrents/download/", Method.GET);
            request.AddParameter("hash", hash);

            var response = Execute<TorrentDownloadUrlResponse>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.Data == null)
                return null; // TODO: throw an exception?

            return response.Data.Url;
        }

        /// <summary>
        /// Gets the total number of indexed torrents.
        /// </summary>
        /// <returns>The total number of indexed torrents.</returns>
        public long GetTorrentCount()
        {
            var request = new RestRequest("torrents/count/", Method.GET);
            var response = Execute<TorrentCountResponse>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.Data == null)
                return 0; // TODO: throw an exception?

            return response.Data.Count;
        }

        /// <summary>
        /// Searches torrents using the given phrase, category and subcategory.
        /// </summary>
        /// <param name="phrase">A search phrase.</param>
        /// <param name="category">A <see cref="Category"/>.</param>
        /// <param name="subcategory">A <see cref="Subcategory"/>.</param>
        /// <returns>A list of <see cref="TorrentInfoResponse"/>.</returns>
        public List<TorrentInfoResponse> SearchTorrents(
            string phrase,
            Category category = null,
            Subcategory subcategory = null)
        {
            if (string.IsNullOrEmpty(phrase))
                throw new ArgumentNullException("phrase");

            var request = new RestRequest("torrents/search/", Method.GET);
            request.AddParameter("phrase", phrase);

            // TODO: Should I be responsible for checking the category/subcategory?
            if (category != null)
                request.AddParameter("category", category.Name);

            if (subcategory != null)
                request.AddParameter("subcategory", subcategory.Name);

            var response = Execute<TorrentInfoResponses>(request);
            if (response.StatusCode != HttpStatusCode.OK || response.Data == null)
                return new List<TorrentInfoResponse>(); // TODO: throw an exception?

            return response.Data.Torrents;
        }
    }
}

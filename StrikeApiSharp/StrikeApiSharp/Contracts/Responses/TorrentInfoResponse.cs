// ****************************************
// Assembly : NetflixRouletteSharp
// File     : TorrentInfoResponse.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace StrikeApiSharp.Contracts.Responses
{
    public class TorrentInfoResponse
    {
        [JsonProperty("torrent_hash")]
        public string TorrentHash { get; private set; }

        [JsonProperty("torrent_title")]
        public string TorrentTitle { get; private set; }

        [JsonProperty("torrent_category")]
        public string TorrentCategory { get; private set; }

        [JsonProperty("sub_category")]
        public string TorrentSubCategory { get; private set; }

        [JsonProperty("seeds")]
        public int Seeds { get; private set; }

        [JsonProperty("leeches")]
        public int Leeches { get; private set; }

        [JsonProperty("file_count")]
        public int FileCount { get; private set; }

        [JsonProperty("size")]
        public long Size { get; private set; }

        [JsonProperty("upload_date")]
        public DateTime UploadDate { get; private set; }

        [JsonProperty("uploader_username")]
        public string UploaderUsername { get; private set; }

        [JsonProperty("file_info")]
        public List<TorrentFileInfo> FileInfo { get; private set; }

        [JsonProperty("magnet_uri")]
        public Uri MagnetUri { get; private set; }
    }
}

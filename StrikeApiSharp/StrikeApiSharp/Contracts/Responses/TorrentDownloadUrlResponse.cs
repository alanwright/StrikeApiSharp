// ****************************************
// Assembly : StrikeApiSharp
// File     : TorrentDownloadUrlResponse.cs
// Author   : Alan Wright
// ****************************************
// Created  : 05/09/2015
// ****************************************

using Newtonsoft.Json;

namespace StrikeApiSharp.Contracts.Responses
{
    public class TorrentDownloadUrlResponse
    {
        [JsonProperty("message")]
        public string Url { get; private set; }
    }
}

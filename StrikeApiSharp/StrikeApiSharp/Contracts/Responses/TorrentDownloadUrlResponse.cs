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
        public string Url { get { return Message; } }

        [JsonProperty("message")]
        public string Message { private get; set; }
    }
}

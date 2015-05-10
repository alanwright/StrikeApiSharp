// ****************************************
// Assembly : NetflixRouletteSharp
// File     : TorrentDescriptionResponse.cs
// Author   : Alan Wright
// ****************************************
// Created  : 05/09/2015
// ****************************************

using Newtonsoft.Json;

namespace StrikeApiSharp.Contracts.Responses
{
    public class TorrentDescriptionResponse
    {
        public string Description { get { return Message; } }

        [JsonProperty("message")]
        public string Message { get; private set; }
    }
}

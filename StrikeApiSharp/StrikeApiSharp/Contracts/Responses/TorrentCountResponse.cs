﻿// ****************************************
// Assembly : StrikeApiSharp
// File     : TorrentCountResponse.cs
// Author   : Alan Wright
// ****************************************
// Created  : 05/09/2015
// ****************************************

using Newtonsoft.Json;

namespace StrikeApiSharp.Contracts.Responses
{
    public class TorrentCountResponse
    {
        [JsonProperty("message")]
        public long Count { get; private set; }
    }
}

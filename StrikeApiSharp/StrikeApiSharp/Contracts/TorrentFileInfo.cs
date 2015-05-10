// ****************************************
// Assembly : StrikeApiSharp
// File     : TorrentFileInfo.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using Newtonsoft.Json;
using System.Collections.Generic;

namespace StrikeApiSharp.Contracts
{
    public class TorrentFileInfo
    {
        [JsonProperty("file_names")]
        public List<string> FileNames { get; private set; }

        [JsonProperty("file_lengths")]
        public List<long> FileLengths { get; private set; }
    }
}

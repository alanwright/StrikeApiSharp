// ****************************************
// Assembly : StrikeApiSharp
// File     : TorrentInfoResponses.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using System.Collections.Generic;

namespace StrikeApiSharp.Contracts.Responses
{
    public class TorrentInfoResponses
    {
        public List<TorrentInfoResponse> Torrents { get; private set; }
    }
}

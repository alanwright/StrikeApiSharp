// ****************************************
// Assembly : StrikeApiTests
// File     : StrikeApiTests.cs
// Author   : Alan Wright
// ****************************************
// Created  : 04/18/2015
// ****************************************

using System;
using System.Collections.Generic;
using StrikeApiSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrikeApiTests
{
    [TestClass]
    public class StrikeApiTests
    {
        [TestMethod]
        public void GetTorrentTest()
        {
            var strikeApi = new StrikeApi();
            var hash = "B425907E5755031BDA4A8D1B6DCCACA97DA14C04";
            var torrentResponse = strikeApi.GetTorrent(hash);

            Assert.IsNotNull(torrentResponse);
            Assert.AreEqual(torrentResponse.TorrentTitle, "Arch Linux 2015.01.01 (x86/x64)");
        }

        [TestMethod]
        public void GetTorrent_BadHashTest()
        {
            var strikeApi = new StrikeApi();
            var hash = "BADHASH";
            var torrentResponse = strikeApi.GetTorrent(hash);

            Assert.IsNull(torrentResponse);
        }

        [TestMethod]
        public void GetTorrentsTest()
        {
            var strikeApi = new StrikeApi();
            List<string> hashes = new List<string>
            {
                "B425907E5755031BDA4A8D1B6DCCACA97DA14C04",
                "156B69B8643BD11849A5D8F2122E13FBB61BD041",
            };
            var torrentResponses = strikeApi.GetTorrents(hashes);

            Assert.IsNotNull(torrentResponses);
            Assert.IsTrue(torrentResponses.Count == hashes.Count);

            var arr = torrentResponses.ToArray();
            var torrent1 = arr[0];
            var torrent2 = arr[1];

            Assert.AreEqual(torrent1.TorrentTitle, "Slackware 14.1 x86_64 DVD ISO");
            Assert.AreEqual(torrent2.TorrentTitle, "Arch Linux 2015.01.01 (x86/x64)");
        }

        [TestMethod]
        public void GetTorrents_BadHashTest()
        {
            var strikeApi = new StrikeApi();
            List<string> hashes = new List<string>
            {
                "BADHASH",
            };
            var torrentResponses = strikeApi.GetTorrents(hashes);

            Assert.IsNotNull(torrentResponses);
            Assert.IsTrue(torrentResponses.Count == 0);
        }

        [TestMethod]
        public void GetTorrents_GoodAndBadHashTest()
        {
            var strikeApi = new StrikeApi();
            List<string> hashes = new List<string>
            {
                "B425907E5755031BDA4A8D1B6DCCACA97DA14C04",
                "156B69B8643BD11849A5D8F2122E13FBB61BD041",
                "BADHASH",
            };
            var torrentResponses = strikeApi.GetTorrents(hashes);

            Assert.IsNotNull(torrentResponses);
            Assert.IsTrue(torrentResponses.Count == hashes.Count - 1);

            var arr = torrentResponses.ToArray();
            var torrent1 = arr[0];
            var torrent2 = arr[1];

            Assert.AreEqual(torrent1.TorrentTitle, "Slackware 14.1 x86_64 DVD ISO");
            Assert.AreEqual(torrent2.TorrentTitle, "Arch Linux 2015.01.01 (x86/x64)");
        }
    }
}

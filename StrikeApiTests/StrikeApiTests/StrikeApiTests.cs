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
        public void GetTorrent_Test()
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
        public void GetTorrents_Test()
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

        [TestMethod]
        public void GetTorrentCount_Test()
        {
            var strikeApi = new StrikeApi();
            var torrentCount = strikeApi.GetTorrentCount();

            Assert.IsNotNull(torrentCount);
            Assert.IsTrue(torrentCount > 0);
        }

        [TestMethod]
        public void SearchTorrents_PhraseTest()
        {
            var strikeApi = new StrikeApi();
            var searchPhrase = "Batman";
            var torrentResponses = strikeApi.SearchTorrents(searchPhrase);

            Assert.IsNotNull(torrentResponses);
            Assert.IsTrue(torrentResponses.Count > 0);
        }

        [TestMethod]
        public void SearchTorrents_NullPhraseTest()
        {
            bool success = false;
            var strikeApi = new StrikeApi();
            try
            {
                var torrentResponses = strikeApi.SearchTorrents(null);
            }
            catch(Exception e)
            {
                success = e is ArgumentNullException;
            }

            Assert.IsTrue(success);
        }

        [TestMethod]
        public void SearchTorrents_PhraseCategoryTest()
        {
            var strikeApi = new StrikeApi();
            var searchPhrase = "Batman";
            var searchCategory = Categories.Books;
            var torrentResponses = strikeApi.SearchTorrents(searchPhrase, searchCategory);

            Assert.IsNotNull(torrentResponses);
            Assert.IsTrue(torrentResponses.Count > 0);

            // Ensure all categories are matching
            var resultsWithMatchingCategory = torrentResponses.FindAll(t => t.TorrentCategory == searchCategory.Name);
            Assert.IsTrue(resultsWithMatchingCategory.Count == torrentResponses.Count);
        }

        [TestMethod]
        public void SearchTorrents_PhraseSubcategoryTest()
        {
            var strikeApi = new StrikeApi();
            var searchPhrase = "Batman";
            var searchSubcategory = Subcategories.Comics;
            var torrentResponses = strikeApi.SearchTorrents(searchPhrase, subcategory: searchSubcategory);

            Assert.IsNotNull(torrentResponses);
            Assert.IsTrue(torrentResponses.Count > 0);

            // TODO: Follow up with API author. Specifying a subcategory only has no effect.
            // Ensure all subcategories are matching
            // var resultsWithMatchingCategory = torrentResponses.FindAll(t => t.SubCategory == searchSubcategory.Name);
            // Assert.IsTrue(resultsWithMatchingCategory.Count == torrentResponses.Count);
        }

        [TestMethod]
        public void SearchTorrents_PhraseCategorySubcategoryTest()
        {
            var strikeApi = new StrikeApi();
            var searchPhrase = "Batman";
            var searchCategory = Categories.Books;
            var searchSubcategory = Subcategories.Comics;
            var torrentResponses = strikeApi.SearchTorrents(searchPhrase, searchCategory, searchSubcategory);

            Assert.IsNotNull(torrentResponses);
            Assert.IsTrue(torrentResponses.Count > 0);

            // Ensure all categories and subcategories are matching
            var resultsWithMatchingCategory = torrentResponses.FindAll(t => t.TorrentCategory == searchCategory.Name && t.SubCategory == searchSubcategory.Name);
            Assert.IsTrue(resultsWithMatchingCategory.Count == torrentResponses.Count);
        }

        [TestMethod]
        public void GetTorrentDownloadUrl_Test()
        {
            var strikeApi = new StrikeApi();
            var hash = "0EB6605E041F1846B84BAA63346012A82706A95D";
            var torrentUrl = strikeApi.GetTorrentDownloadUrl(hash);

            Assert.IsTrue(!string.IsNullOrEmpty(torrentUrl));
        }

        [TestMethod]
        public void GetTorrentDescription_Test()
        {
            var strikeApi = new StrikeApi();
            var hash = "0EB6605E041F1846B84BAA63346012A82706A95D";
            var torrentUrl = strikeApi.GetTorrentDescription(hash);

            Assert.IsTrue(!string.IsNullOrEmpty(torrentUrl));
        }
    }
}

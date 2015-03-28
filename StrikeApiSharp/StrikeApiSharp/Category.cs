// ****************************************
// Assembly : NetflixRouletteSharp
// File     : Category.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikeApiSharp
{
    public sealed class Category : IComparable<Category>
    {
        #region Static Constructor

        static Category()
        {
            Categories = new List<Category>
            {
                new Category("Anime"),
                new Category("Applications"),
                new Category("Books"),
                new Category("Games"),
                new Category("Movies"),
                new Category("Music"),
                new Category("Other"),
                new Category("TV"),
                new Category("XXX"),
            };
        }

        #endregion

        /// <summary>
        /// Creates a new Category.
        /// </summary>
        /// <param name="name">The name of the category</param>
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        // Initialized in static constructor
        private static List<Category> Categories;

        public int CompareTo(Category other)
        {
            return other != null ? string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase) : 0;
        }

        public List<Category> GetCategories()
        {
            return Categories;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

// ****************************************
// Assembly : NetflixRouletteSharp
// File     : Category.cs
// Author   : Alan Wright
// ****************************************
// Created  : 03/28/2015
// ****************************************

using System;

namespace StrikeApiSharp
{
    public sealed class Category : IComparable<Category>
    {
        /// <summary>
        /// Creates a new Category.
        /// </summary>
        /// <param name="name">The name of the category</param>
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public int CompareTo(Category other)
        {
            return other != null ? string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase) : 0;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    #region Hard-Coded Categories

    public static class Categories
    {
        public static Category Anime { get { return new Category("Anime"); } }
        public static Category Applications { get { return new Category("Applications"); } }
        public static Category Books { get { return new Category("Books"); } }
        public static Category Games { get { return new Category("Games"); } }
        public static Category Movies { get { return new Category("Movies"); } }
        public static Category Music { get { return new Category("Music"); } }
        public static Category Other { get { return new Category("Other"); } }
        public static Category Tv { get { return new Category("TV"); } }
        public static Category Xxx { get { return new Category("XXX"); } }
    }

    #endregion
}

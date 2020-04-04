using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class Category
    {
        public Category()
        {
            Games = new HashSet<Game>();
            Subcategories = new HashSet<Subcategory>();
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}

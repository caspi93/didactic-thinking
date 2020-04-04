using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class Categorie
    {
        public Categorie()
        {
            Games = new HashSet<Game>();
            Subcategories = new HashSet<Subcategorie>();
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Subcategorie> Subcategories { get; set; }
    }
}

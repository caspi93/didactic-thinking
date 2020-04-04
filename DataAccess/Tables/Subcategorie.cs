using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class Subcategorie
    {
        public Subcategorie()
        {
            Games = new HashSet<Game>();
            Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategorieId { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class Subcategory
    {
        public Subcategory()
        {
            Games = new HashSet<Game>();
            Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}

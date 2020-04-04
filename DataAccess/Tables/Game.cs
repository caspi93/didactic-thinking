using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class Game
    {
        public Game()
        {
            GameQuestions = new HashSet<GameQuestion>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int? Score { get; set; }
        public int? SubcategoryId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Category Category { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<GameQuestion> GameQuestions { get; set; }
    }
}

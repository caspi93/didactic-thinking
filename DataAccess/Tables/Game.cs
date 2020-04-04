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
        public int CategoriaId { get; set; }
        public int? Score { get; set; }
        public int? SubcategorieId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Categorie Categoria { get; set; }
        public virtual Subcategorie Subcategorie { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<GameQuestion> GameQuestions { get; set; }
    }
}

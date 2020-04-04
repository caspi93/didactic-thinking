using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class Game {

        public Game() { }

        public Game(DataAccess.Tables.Game game) {
            Id = game.Id;
            UserId = game.UserId;
            CategoryId = game.CategoryId;
            Score = game.Score;
            SubcategoryId = game.SubcategoryId;
            Date = game.Date;
            User = new User(game.User);
            Category = new Category(game.Category);
            Subcategory = new Subcategory(game.Subcategory);
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int? Score { get; set; }
        public int? SubcategoryId { get; set; }
        public DateTime? Date { get; set; }

        public Category Category { get; set; }
        public User User { get; set; }

        public Subcategory Subcategory { get; set; }

        public DataAccess.Tables.Game Convert() {
            return new DataAccess.Tables.Game {
                Id = Id,
                UserId = UserId,
                CategoryId = CategoryId,
                Score = Score,
                SubcategoryId = SubcategoryId,
                Date = Date
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class Question {
        public Question() { }

        public Question(DataAccess.Tables.Question question) {
            Id = question.Id;
            SubcategoryId = question.SubcategoryId;
        }

        public int Id { get; set; }
        public int SubcategoryId { get; set; }

        public Subcategory Subcategory { get; set; }

        public DataAccess.Tables.Question Convert() {
            return new DataAccess.Tables.Question {
                Id = Id,
                SubcategoryId = SubcategoryId
            };
        }
    }
}

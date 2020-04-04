using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class Subcategory {
        public Subcategory() { }

        public Subcategory(DataAccess.Tables.Subcategory subcategory) {
            Id = subcategory.Id;
            Name = subcategory.Name;
            CategoryId = subcategory.CategoryId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public DataAccess.Tables.Subcategory Convert() {
            return new DataAccess.Tables.Subcategory {
                Id = Id,
                Name = Name,
                CategoryId = CategoryId
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class Category {

        public Category() {}
        public Category(DataAccess.Tables.Category category) {
            Id = category.Id;
            Name = category.Name;
        }
        public string Name { get; set; }
        public int Id { get; set; }

        public DataAccess.Tables.Category Convert() {
            return new DataAccess.Tables.Category {
                Id = Id,
                Name = Name
            };
        }
   
    }
}

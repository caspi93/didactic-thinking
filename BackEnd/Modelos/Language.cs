using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class Language {

        public Language() {}

        public Language(DataAccess.Tables.Language language) {
            Id = language.Id;
            Name = language.Name;
            Code = language.Code;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public DataAccess.Tables.Language Convertir() {
            return new DataAccess.Tables.Language {
                Id = Id,
                Name = Name,
                Code = Code
            };
        }
    }
}

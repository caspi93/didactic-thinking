using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class LanguageAnswer {
        public LanguageAnswer() {

        }

        public LanguageAnswer(DataAccess.Tables.LanguageAnswer languageAnswer) {
            AnswerId = languageAnswer.AnswerId;
            LanguageId = languageAnswer.LanguageId;
            Name = languageAnswer.Name;
            Answer = new Answer(languageAnswer.Answer);
            Language = new Language(languageAnswer.Language);
        }

        public int AnswerId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public Answer Answer { get; set; }
        public Language Language { get; set; }

        public DataAccess.Tables.LanguageAnswer Convert() {
            return new DataAccess.Tables.LanguageAnswer {
                AnswerId = AnswerId,
                LanguageId = LanguageId,
                Name = Name
            };
        }
    }
}

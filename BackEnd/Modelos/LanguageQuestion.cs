using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class LanguageQuestion {


        public LanguageQuestion() { }

        public LanguageQuestion(DataAccess.Tables.LanguageQuestion languageQuestion) {
            QuestionId = languageQuestion.QuestionId;
            LanguageId = languageQuestion.LanguageId;
            Body = languageQuestion.Body;
            Question = new Question(languageQuestion.Question);
            Language = new Language(languageQuestion.Language);
        }
        public int QuestionId { get; set; }
        public int LanguageId { get; set; }
        public string Body { get; set; }

        public Language Language { get; set; }
        public Question Question { get; set; }

        public DataAccess.Tables.LanguageQuestion Convert() {
            return new DataAccess.Tables.LanguageQuestion {
                QuestionId = QuestionId,
                LanguageId = LanguageId,
                Body = Body
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class Answer {

        public Answer() {

        }
        public Answer(DataAccess.Tables.Answer answer) {
            Id = answer.Id;
            Iscorrect = answer.Iscorrect;
            QuestionId = answer.QuestionId;
            Question = new Question(answer.Question);
        }
        public int Id { get; set; }
        public bool Iscorrect { get; set; }
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public DataAccess.Tables.Answer Convert() {
            return new DataAccess.Tables.Answer {
                Id = Id,
                Iscorrect = Iscorrect,
                QuestionId = QuestionId
            };
        }
    }
}

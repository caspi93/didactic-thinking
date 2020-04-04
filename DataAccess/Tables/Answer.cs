using System;
using System.Collections.Generic;

namespace DataAccess.Tables {
    public partial class Answer {
        public Answer() {
            LanguagesAnswer = new HashSet<LanguageAnswer>();
        }

        public int Id { get; set; }
        public bool Iscorrect { get; set; }
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<LanguageAnswer> LanguagesAnswer { get; set; }
    }
}

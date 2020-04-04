using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            GameQuestions = new HashSet<GameQuestion>();
            LanguagesQuestion = new HashSet<LanguageQuestion>();
        }

        public int Id { get; set; }
        public int SubcategorieId { get; set; }

        public virtual Subcategorie Subcategorie { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<GameQuestion> GameQuestions { get; set; }
        public virtual ICollection<LanguageQuestion> LanguagesQuestion { get; set; }
    }
}

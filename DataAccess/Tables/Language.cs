using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class Language
    {
        public Language()
        {
            LanguagesAnswer = new HashSet<LanguageAnswer>();
            LanguagesQuestion = new HashSet<LanguageQuestion>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<LanguageAnswer> LanguagesAnswer { get; set; }
        public virtual ICollection<LanguageQuestion> LanguagesQuestion { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

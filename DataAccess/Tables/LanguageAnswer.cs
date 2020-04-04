using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class LanguageAnswer
    {
        public int AnswerId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual Language Language { get; set; }
    }
}

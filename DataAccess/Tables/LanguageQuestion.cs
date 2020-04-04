using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class LanguageQuestion
    {
        public int QuestionId { get; set; }
        public int LanguageId { get; set; }
        public string Body { get; set; }

        public virtual Language Language { get; set; }
        public virtual Question Question { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class GameQuestion
    {
        public int GameId { get; set; }
        public int QuestionId { get; set; }

        public virtual Game Game { get; set; }
        public virtual Question Question { get; set; }
    }
}

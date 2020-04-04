using System;
using System.Collections.Generic;

namespace DataAccess.Tables
{
    public partial class User
    {
        public User()
        {
            Games = new HashSet<Game>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
        public byte[] Picture { get; set; }
        public int LanguajeId { get; set; }

        public virtual Language Languaje { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}

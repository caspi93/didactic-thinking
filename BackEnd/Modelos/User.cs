using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Modelos {
    public class User {

        public User() { }

        public User(DataAccess.Tables.User user) {
            Id = user.Id;
            Username = user.Username;
            Password = user.Password;
            Email = user.Email;
            Enabled = user.Enabled;
            Picture = user.Picture;
            LanguajeId = user.LanguajeId;
            Language = new Language(user.Languaje);
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
        public byte[] Picture { get; set; }
        public int LanguajeId { get; set; }

        public Language Language { get; set; }

        public DataAccess.Tables.User Convert() {
            return new DataAccess.Tables.User {
                Id = Id,
                Username = Username,
                Password = Password,
                Email = Email,
                Enabled = Enabled,
                Picture = Picture,
                LanguajeId = LanguajeId
            };
        }

    }

}


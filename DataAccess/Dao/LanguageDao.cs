using DataAccess.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Dao {
    public class LanguageDao {
        private Entities db;

        public LanguageDao(Entities db) {
            this.db = db;
        }

        public IEnumerable<Language> GetLanguages() {
            return db.Languages.ToList();
        }
    }
}

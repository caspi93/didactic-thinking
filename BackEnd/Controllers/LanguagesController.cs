using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Dao;
using DataAccess.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BackEnd.Controllers {
    [ApiController]
    [Route("api/languages")]
    public class LanguagesController : ControllerBase {

        private readonly Entities db;

        public LanguagesController(Entities db) {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Language> Get() {
            var languageDao = new LanguageDao(db);
            return languageDao.GetLanguages();
        }

    }
}

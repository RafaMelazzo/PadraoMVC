using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PadraoMVC.Controllers
{
    public class LivrosController : Controller
    {
        // /livros
        // /livros/143978
        [Route("livros/{isbn?}")]
        public ActionResult Get(string isbn)
        {
            if (!string.IsNullOrEmpty(isbn))
            {
                return Content("livro específico: " + isbn);
            }

            return Content("todos os livros.");
        }

        // /livros/idioma
        // /livros/idioma/en
        // /livros/idioma/de
        [Route("livros/idioma/{idioma=ptBR}")]
        public ActionResult GetByLanguage(string idioma)
        {
            return Content($"Todos os livros no idioma: {idioma}");
        }

        // /livros/autor/5
        [Route("livros/autor/{id:int}")]
        public ActionResult GetAuthorById(int id)
        {
            return Content($"Livros do Autor com o id: {id}");
        }

        // /livros/autor/Tolkien
        [Route("livros/autor/{name}")]
        public ActionResult GetAuthorByName(string name)
        {
            return Content($"Livros do autor com o nome: {name}");
        }
    }
}
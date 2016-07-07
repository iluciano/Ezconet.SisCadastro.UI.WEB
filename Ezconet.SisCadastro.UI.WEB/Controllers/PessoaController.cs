using Ezconet.SisCadastro.UI.WEB.Models;
using Ezconet.SisCadastro.UI.WEB.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ezconet.SisCadastro.UI.WEB.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        [HttpGet]
        public ActionResult CadastroPessoa()
        {
            return View("CadastroPessoa");
        }

        [HttpPost]
        public ActionResult CadastroPEssoa(PessoaMOD model)
        {
            if (ModelState.IsValid)
            {
                using(var conexao = new Conexao())
                {
                    conexao.Pessoa.Add(model);
                    conexao.SaveChanges();
                }
            }
            return View();
        }

        public ActionResult ListarPessoa()
        {
            using (var conexao = new Conexao())
            {
                var pessoas = conexao.Pessoa.ToList();
                return View("ListarPessoa", pessoas);
            }
        }
    }
}
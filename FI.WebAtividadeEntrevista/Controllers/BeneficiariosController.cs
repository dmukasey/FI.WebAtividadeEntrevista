using FI.AtividadeEntrevista.BLL;
using FI.AtividadeEntrevista.DML;
using FI.WebAtividadeEntrevista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace FI.WebAtividadeEntrevista.Controllers
{
    public class BeneficiariosController : Controller
    {
        // GET: Beneficiarios

        // [Route("Beneficiarios/Index/{id?}")]
        public ActionResult Index(string mensagem = "")
        {
            if (mensagem != "")
                ViewBag.Mensagem = mensagem;

            var lista = new List<BeneficiarioModel>();
            BoBeneficiario boBeneficiario = new BoBeneficiario();

            //OBS:abaixo hardcoded pois no momento do cadastro como sugerido no teste não tenho o idcliente para passar
            return View(boBeneficiario.Listar(1));
        }

        [HttpPost]
        public ActionResult Incluir(string CPF, string Nome)
        {
            if(! Utils.CPFValidator.IsCpf(CPF))
                return RedirectToAction("Index", "Beneficiarios", new { mensagem = "CPF invalido" });



            BoBeneficiario boBeneficiario = new BoBeneficiario();
            if (boBeneficiario.VerificarExistencia(CPF))
                return RedirectToAction("Index", "Beneficiarios", new { mensagem = "CPF ja existe na base de dados" });


            Beneficiario beneficiario = new Beneficiario();
            beneficiario.NOME = Nome;
            beneficiario.CPF = CPF;
            //OBS:abaixo hardcoded pois no momento do cadastro como sugerido no teste não tenho o idcliente para passar
            beneficiario.IDCLIENTE = 1;



          



            boBeneficiario.Incluir(beneficiario);

            return RedirectToAction("Index", "Beneficiarios");
        }

        [HttpPost]
        public ActionResult Excluir(int ID)
        {
             BoBeneficiario boBeneficiario = new BoBeneficiario();
             boBeneficiario.Excluir(ID);

            return RedirectToAction("Index", "Beneficiarios", new { mensagem = "Beneficiario Excluido com Sucesso" });
            
        }


        [HttpPost]
        public ActionResult Alterar(int ID, string CPF, string Nome)
        {
            if (!Utils.CPFValidator.IsCpf(CPF))
                return RedirectToAction("Index", "Beneficiarios", new { mensagem = "CPF invalido" });

            BoBeneficiario boBeneficiario = new BoBeneficiario();
            Beneficiario beneficiario = new Beneficiario();
            beneficiario.NOME = Nome;
            beneficiario.CPF = CPF;
            beneficiario.ID = ID;
            boBeneficiario.Alterar(beneficiario);

            
            return RedirectToAction("Index", "Beneficiarios",  new {  mensagem = "Beneficiario Alterado com Sucesso" });
        }
    }
}
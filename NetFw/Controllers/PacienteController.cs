using NetFw.Servico;
using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFw.Controllers
{
    public class PacienteController : Controller
    {
        public ActionResult Index()
        {
            ServicoSOAP servicoSOAP = new ServicoSOAP();
            return View(servicoSOAP.GetMeusPacientes());
        }

        public ActionResult Editar(int id)
        {
            ServicoSOAP servicoSOAP = new ServicoSOAP();
            return View(servicoSOAP.GetPacientePorId(id));
        }

        [HttpPost]
        public ActionResult Editar(PacienteTO paciente)
        {
            ServicoSOAP servicoSOAP = new ServicoSOAP();
            servicoSOAP.AtualizaPaciente(paciente);

            return View("Sucesso");
        }
    }
}
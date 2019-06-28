using NetFw.Negocio;
using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NetFw.Servico
{
    /// <summary>
    /// Descrição resumida de ServicoSOAP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoSOAP : System.Web.Services.WebService
    {

        [WebMethod]
        public List<PacienteTO> GetMeusPacientes()
        {
            PacienteNegocio nPaciente = new PacienteNegocio();
            return nPaciente.GetMeusPacientes();
        }

        [WebMethod]
        public PacienteTO GetPacientePorId(int id)
        {
            PacienteNegocio nPaciente = new PacienteNegocio();
            return nPaciente.GetPacientePorId(id);
        }

        [WebMethod]
        public void AtualizaPaciente(PacienteTO paciente)
        {
            PacienteNegocio nPaciente = new PacienteNegocio();
            nPaciente.AtualizaPaciente(paciente);
        }
    }
}

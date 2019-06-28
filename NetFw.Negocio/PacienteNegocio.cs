using NetFw.Repositorio;
using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Negocio
{
  public class PacienteNegocio
  {
    public List<PacienteTO> GetMeusPacientes()
    {
      //Algumas vezes este tipo de instância pode ser um broker, via reflection
      IPacienteRepositorio repPaciente = RepositorioFactory.NovoPacienteRepositorio(); 
      return repPaciente.GetTodos();
    }

    public PacienteTO GetPacientePorId(int id)
    {
      IPacienteRepositorio repPaciente = RepositorioFactory.NovoPacienteRepositorio();
      return repPaciente.GetPacientePorId(id);
    }
    public void NovoPaciente(PacienteTO paciente)
    {
      IPacienteRepositorio repPaciente = RepositorioFactory.NovoPacienteRepositorio();
      repPaciente.Novo(paciente);
    }

    public void AtualizaPaciente(PacienteTO paciente)
    {
      IPacienteRepositorio repPaciente = RepositorioFactory.NovoPacienteRepositorio();
      repPaciente.Atualiza(paciente);
    }

  }
}

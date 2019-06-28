using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Repositorio
{
  public interface IPacienteRepositorio
  {
    void Novo(PacienteTO paciente);
    List<PacienteTO> GetTodos();
    PacienteTO GetPacientePorId(int id);
    void Atualiza(PacienteTO paciente);
  }
}

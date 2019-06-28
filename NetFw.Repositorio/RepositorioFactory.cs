using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Repositorio
{
  public static class RepositorioFactory
  {
    public static IPacienteRepositorio NovoPacienteRepositorio()
    {
      return new PacienteRepositorio();
    }
  }
}

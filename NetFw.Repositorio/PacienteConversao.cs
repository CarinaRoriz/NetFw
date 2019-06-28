using NetFw.Dados;
using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Repositorio
{
  internal static class PacienteConversao
  {
    internal static PacienteTO ToPacienteTO(this Paciente entity)
    {
      PacienteTO to = new PacienteTO();

      if (entity == null)
        return null;

      to.Id = entity.Id;
      to.Nome = entity.Nome;
      to.NomeMae = entity.NomeMae;
      to.Nascimento = entity.Nascimento;
      to.Sexo = (SexoEnum)entity.Sexo;

      return to;
    }

    internal static void Apply(this Paciente entity, PacienteTO to)
    {
      entity.Nome = to.Nome;
      entity.NomeMae = to.NomeMae;
      entity.Nascimento = to.Nascimento;
      entity.Sexo = (int)to.Sexo;
    }
  }
}

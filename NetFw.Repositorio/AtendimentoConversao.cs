using NetFw.Dados;
using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Repositorio
{
  internal static class AtendimentoConversao
  {
    internal static AtendimentoTO ToAtendimentoTO(this Atendimento entity)
    {
      AtendimentoTO to = new AtendimentoTO();

      if (entity == null)
        return null;

      to.Id = entity.Id;
      //to.Nome = entity.Nome;
      //to.NomeMae = entity.NomeMae;
      //to.Nascimento = entity.Nascimento;
      //to.Sexo = (SexoEnum)entity.Sexo;

      return to;
    }

    internal static void Apply(this Atendimento entity, AtendimentoTO to)
    {
      //entity.Nome = to.Nome;
      //entity.NomeMae = to.NomeMae;
      //entity.Nascimento = to.Nascimento;
      //entity.Sexo = (int)to.Sexo;
    }
  }
}

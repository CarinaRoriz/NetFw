using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Repositorio
{
  public interface IAtendimentoRepositorio
  {
    void Novo(AtendimentoTO atendimento);
    List<AtendimentoTO> GetTodos();
    AtendimentoTO GetPacientePorId(int id);
    void Atualiza(AtendimentoTO atendimento);
  }
}

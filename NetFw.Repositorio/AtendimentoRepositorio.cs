using NetFw.Dados;
using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Repositorio
{
  internal class AtendimentoRepositorio : RepositorioBase, IAtendimentoRepositorio
  {
    public AtendimentoRepositorio()
    {

    }

    internal Atendimento GetAtendimento(int id)
    {
      return this.Contexto.Atendimentoes.Where(p => p.Id == id).FirstOrDefault();
    }

    public AtendimentoTO GetPacientePorId(int id)
    {
      return GetAtendimento(id).ToAtendimentoTO();
    }

    public List<AtendimentoTO> GetTodos()
    {
      List<Atendimento> atendimentos = this.Contexto.Atendimentoes.ToList();
      return atendimentos.Select(s => s.ToAtendimentoTO()).ToList();
    }

    public void Novo(AtendimentoTO atendimento)
    {
      Atendimento entity = new Atendimento();
      entity.DataCriacao = DateTime.Now;
      entity.DataModificacao = DateTime.Now;
      entity.Apply(atendimento);
      this.Contexto.Atendimentoes.Add(entity);
      this.Contexto.SaveChanges();
    }

    public void Atualiza(AtendimentoTO atendimento)
    {
      Atendimento entity = this.GetAtendimento(atendimento.Id);
      entity.Apply(atendimento);
      entity.DataModificacao = DateTime.Now;
      this.Contexto.Entry(entity).State = EntityState.Modified;
      this.Contexto.SaveChanges();
    }
  }
}

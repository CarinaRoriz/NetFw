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
  internal class PacienteRepositorio : RepositorioBase, IPacienteRepositorio
  {
    //public PacienteRepositorio(ArqSoftwareDotNetEntities contexto)
    //{
    //  this.Contexto = contexto;
    //}

    public PacienteRepositorio()
    {

    }

    internal Paciente GetPaciente(int id)
    {
      return this.Contexto.Pacientes.Where(p => p.Id == id).FirstOrDefault();
    }

    public PacienteTO GetPacientePorId(int id)
    {
      return GetPaciente(id).ToPacienteTO();
    }

    public List<PacienteTO> GetTodos()
    {
      List<Paciente> pacientes = this.Contexto.Pacientes.ToList();
      return pacientes.Select(s => s.ToPacienteTO()).ToList();
    }

    public void Novo(PacienteTO paciente)
    {
      Paciente entity = new Paciente();
      entity.DataCriacao = DateTime.Now;
      entity.DataModificacao = DateTime.Now;
      entity.Apply(paciente);
      this.Contexto.Pacientes.Add(entity);
      this.Contexto.SaveChanges();
    }

    public void Atualiza(PacienteTO paciente)
    {
      Paciente entity = this.GetPaciente(paciente.Id);
      entity.Apply(paciente);
      entity.DataModificacao = DateTime.Now;
      this.Contexto.Entry(entity).State = EntityState.Modified;
      this.Contexto.SaveChanges();
    }
  }
}

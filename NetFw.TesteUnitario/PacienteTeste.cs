using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFw.Negocio;
using NetFw.Repositorio;
using NetFw.TO;

namespace NetFw.TesteUnitario
{
  [TestClass]
  public class PacienteTeste
  {
    [TestMethod]
    public void Teste()
    {
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void GetMeusPacientes()
    {
      PacienteNegocio negPaciente = new PacienteNegocio();
      List<PacienteTO> pacientes = negPaciente.GetMeusPacientes();
      Assert.IsNotNull(pacientes);
    }

    [TestMethod]
    public void NovoPaciente()
    {
      PacienteTO paciente = new PacienteTO();
      paciente.Nome = "Criado por Teste Unitário";
      paciente.NomeMae = "TESTE";
      paciente.Nascimento = DateTime.Today.AddYears(-18);
      paciente.Sexo = SexoEnum.Masculino;

      PacienteNegocio negPaciente = new PacienteNegocio();
      negPaciente.NovoPaciente(paciente);
    }


    [TestMethod]
    public void AtualizaPaciente()
    {

      PacienteNegocio negPaciente = new PacienteNegocio();
      List<PacienteTO> pacientes = negPaciente.GetMeusPacientes();

      if (pacientes.Count > 0)
      {
        var paciente = pacientes[0];
        paciente.Nome = "Atualizado por Teste Unitário";
        negPaciente.AtualizaPaciente(paciente);
      }else
      {
        Assert.Inconclusive();
      }
    }
  }
}

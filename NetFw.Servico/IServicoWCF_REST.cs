﻿using NetFw.TO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NetFw.Servico
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IServicoWCF_REST" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServicoWCF_REST
    {
        [OperationContract]
        List<PacienteTO> GetMeusPacientes();

        [OperationContract]
        PacienteTO GetPacientePorId(int id);

        [OperationContract]
        void AtualizaPaciente(PacienteTO paciente);
    }
}

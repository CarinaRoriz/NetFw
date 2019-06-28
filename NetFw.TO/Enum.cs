using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.TO
{
  public enum SexoEnum
  {
    Masculino = 1,
    Feminino = 2,
    NaoInformado = 0
  }

  public enum StatusEmRelacaoAoBanco
  {
    NaoModificado,
    Modificado,
    Adicionado,
    Excluido
  }
}

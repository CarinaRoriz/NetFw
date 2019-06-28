using NetFw.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.Repositorio
{
  public abstract class RepositorioBase
  {
    public ArqSoftwareDotNetEntities Contexto
    {
      get
      {
        return this._contexto;
      }
      set
      {
        this._contexto = value;
      }
    }
    private ArqSoftwareDotNetEntities _contexto;

    public RepositorioBase()
    {
      _contexto = new ArqSoftwareDotNetEntities();
    }
  }
}

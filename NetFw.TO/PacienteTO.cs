using NetFw.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFw.TO
{
  public class PacienteTO : TOBase
  {
    public int Id { get; set; }

    [Required]
    [DisplayName("Nome do Paciente")]
    [StringLength(250)]
    public string Nome { get; set; }

    [DisplayName("Nome da Mãe do Paciente")]
    [StringLength(60)]
    public string NomeMae { get; set; }


    [Required]
    public DateTime? Nascimento { get; set; }

    [Required]
    public SexoEnum Sexo { get; set; }
  }

}

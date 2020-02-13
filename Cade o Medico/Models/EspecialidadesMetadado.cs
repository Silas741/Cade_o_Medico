using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cade_o_Medico.Models
{
    [MetadataType(typeof(EspecialidadesMetadado))]
    public partial class Especialidade
    {

    }

    public class EspecialidadesMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar a Especialidade")]
        [StringLength(80, ErrorMessage = " a especialidade deve possuir no maximo 80 caracteres")]
        public string Nome { get; set; }
    }
}
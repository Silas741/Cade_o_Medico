using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cade_o_Medico.Models
{
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidades
    {

    }
    public class CidadeMetadado
    {
        [Required(ErrorMessage = "Obrigatório informar a Cidade")]
        [StringLength(80, ErrorMessage = "A cidade deve possuir no maximo 80 caracteres")]
        public string Nome { get; set; }
    }

}
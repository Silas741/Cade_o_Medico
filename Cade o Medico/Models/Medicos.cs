//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cade_o_Medico.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicos
    {
        public long IDMedico { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set; }
        public bool AtendimentoPorConvenio { get; set; }
        public bool TemClinica { get; set; }
        public string WebSiteBlog { get; set; }
        public int IDCidade { get; set; }
        public int IDEspecialidade { get; set; }
    
        public virtual Cidades Cidades { get; set; }
        public virtual Especialidade Especialidade { get; set; }
    }
}

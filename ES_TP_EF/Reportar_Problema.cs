//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ES_TP_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reportar_Problema
    {
        public int id { get; set; }
        public short status { get; set; }
        public string descricao { get; set; }
        public string localizacao { get; set; }
        public bool fotos { get; set; }
    
        public virtual Utilizador Utilizador { get; set; }
        public virtual Utilizador Utilizador1 { get; set; }
    }
}

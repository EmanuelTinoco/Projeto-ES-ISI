﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class estp2Entities : DbContext
    {
        public estp2Entities()
            : base("name=estp2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agendamento> Agendamento { get; set; }
        public virtual DbSet<Declaracao> Declaracao { get; set; }
        public virtual DbSet<Freguesia> Freguesia { get; set; }
        public virtual DbSet<Notifcacao> Notifcacao { get; set; }
        public virtual DbSet<Pedido_Declaracao> Pedido_Declaracao { get; set; }
        public virtual DbSet<Pedido_Esclarecimento> Pedido_Esclarecimento { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Reportar_Problema> Reportar_Problema { get; set; }
        public virtual DbSet<Sugestao> Sugestao { get; set; }
        public virtual DbSet<Utilizador> Utilizador { get; set; }
        public virtual DbSet<Utilizador_Perfil> Utilizador_Perfil { get; set; }
    }
}

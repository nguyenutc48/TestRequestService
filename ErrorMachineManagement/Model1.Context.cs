﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErrorMachineManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PAD_MCEMEntities : DbContext
    {
        public PAD_MCEMEntities()
            : base("name=PAD_MCEMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<padmc_currentstatus> padmc_currentstatus { get; set; }
        public virtual DbSet<padmc_error> padmc_error { get; set; }
        public virtual DbSet<padmc_errordevice> padmc_errordevice { get; set; }
        public virtual DbSet<padmc_errortotal> padmc_errortotal { get; set; }
        public virtual DbSet<padmc_leader> padmc_leader { get; set; }
        public virtual DbSet<padmc_line> padmc_line { get; set; }
        public virtual DbSet<padmc_machines> padmc_machines { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sampleapp.context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RutulTrailEntities1 : DbContext
    {
        public RutulTrailEntities1()
            : base("name=RutulTrailEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<OrderTable> OrderTables { get; set; }
        public virtual DbSet<Product_table> Product_table { get; set; }
        public virtual DbSet<tbl_student> tbl_student { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<Demographic> Demographics { get; set; }
    }
}

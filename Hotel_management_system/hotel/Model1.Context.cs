﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hotel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HOTELEntities : DbContext
    {
        public HOTELEntities()
            : base("name=HOTELEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<empPhoto> empPhotoes { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<managment> managments { get; set; }
        public virtual DbSet<room_alo> room_alo { get; set; }
        public virtual DbSet<room> rooms { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<custo> custoes { get; set; }
        public virtual DbSet<sell> sells { get; set; }
        public virtual DbSet<tempOrder> tempOrders { get; set; }
    }
}
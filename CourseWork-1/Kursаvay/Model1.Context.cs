﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursovay
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gr683_zkaEntities : DbContext
    {
        public gr683_zkaEntities()
            : base("name=gr683_zkaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Extradition> Extradition { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Storages> Storages { get; set; }
        public virtual DbSet<TypeEquipment> TypeEquipment { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_Session2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AvailableModules> AvailableModules { get; set; }
        public virtual DbSet<BuildingTypes> BuildingTypes { get; set; }
        public virtual DbSet<Citys> Citys { get; set; }
        public virtual DbSet<ConnectedServices> ConnectedServices { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<CRM> CRM { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EquipmentInstallations> EquipmentInstallations { get; set; }
        public virtual DbSet<Equipments> Equipments { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<KindsAndTypesService> KindsAndTypesService { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<ProblemTypes> ProblemTypes { get; set; }
        public virtual DbSet<Raions> Raions { get; set; }
        public virtual DbSet<ReasonForTerminations> ReasonForTerminations { get; set; }
        public virtual DbSet<ResidentialAddress> ResidentialAddress { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServiceStatus> ServiceStatus { get; set; }
        public virtual DbSet<ServiceTypes> ServiceTypes { get; set; }
        public virtual DbSet<Streets> Streets { get; set; }
        public virtual DbSet<Subscribers> Subscribers { get; set; }
        public virtual DbSet<TypeContracts> TypeContracts { get; set; }
        public virtual DbSet<TypeEquioment> TypeEquioment { get; set; }
        public virtual DbSet<TypeOfServices> TypeOfServices { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModulOtec.Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModulOTECEntities : DbContext
    {
        public ModulOTECEntities()
            : base("name=ModulOTECEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Accesos> Accesos { get; set; }
        public DbSet<Acciones> Acciones { get; set; }
        public DbSet<AnalisisCausa> AnalisisCausa { get; set; }
        public DbSet<Comunas> Comunas { get; set; }
        public DbSet<Documentos> Documentos { get; set; }
        public DbSet<EstadosAccion> EstadosAccion { get; set; }
        public DbSet<EstadosIncidencia> EstadosIncidencia { get; set; }
        public DbSet<Incidencias> Incidencias { get; set; }
        public DbSet<ModosDeteccion> ModosDeteccion { get; set; }
        public DbSet<Organizacion> Organizacion { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<Regiones> Regiones { get; set; }
        public DbSet<RolAcceso> RolAcceso { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<TiposIncidencias> TiposIncidencias { get; set; }
        public DbSet<Tratamientos> Tratamientos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<EvaluacionCumplimiento> EvaluacionCumplimiento { get; set; }
    }
}

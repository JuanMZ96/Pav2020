﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ClassLibrary1
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class BugTrackerFinalEntities : DbContext
{
    public BugTrackerFinalEntities()
        : base("name=BugTrackerFinalEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Asignacione> Asignaciones { get; set; }

    public virtual DbSet<AsistenciaUsuario> AsistenciaUsuarios { get; set; }

    public virtual DbSet<Barrio> Barrios { get; set; }

    public virtual DbSet<Bug> Bugs { get; set; }

    public virtual DbSet<BugsHistorico> BugsHistoricoes { get; set; }

    public virtual DbSet<CasosDePrueba> CasosDePruebas { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<CiclosPrueba> CiclosPruebas { get; set; }

    public virtual DbSet<CiclosPruebaDetalle> CiclosPruebaDetalles { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Criticidade> Criticidades { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Descuento> Descuentos { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstadosAsistencia> EstadosAsistencias { get; set; }

    public virtual DbSet<EstadosUsuario> EstadosUsuarios { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturasDetalle> FacturasDetalles { get; set; }

    public virtual DbSet<Formulario> Formularios { get; set; }

    public virtual DbSet<Objetivo> Objetivos { get; set; }

    public virtual DbSet<ObjetivosCurso> ObjetivosCursos { get; set; }

    public virtual DbSet<Perfile> Perfiles { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PlanesDePrueba> PlanesDePruebas { get; set; }

    public virtual DbSet<Prioridade> Prioridades { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<SueldoAsignacione> SueldoAsignaciones { get; set; }

    public virtual DbSet<SueldoDescuento> SueldoDescuentos { get; set; }

    public virtual DbSet<SueldoPerfilHistorico> SueldoPerfilHistoricoes { get; set; }

    public virtual DbSet<Sueldo> Sueldos { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuariosCurso> UsuariosCursos { get; set; }

    public virtual DbSet<UsuariosCursoAvance> UsuariosCursoAvances { get; set; }

}

}


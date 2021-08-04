using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmpresasColaboradores.Models;

namespace EmpresasColaboradores.DAL
{
    public class EmpresaColaboradoresContext :DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Colaborador> Colaboradores { get; set; }


    }
}
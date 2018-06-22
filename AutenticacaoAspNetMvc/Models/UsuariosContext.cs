using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AutenticacaoAspNetMvc.Models
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext() : base("Usuarios")
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
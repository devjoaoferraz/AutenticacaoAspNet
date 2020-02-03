using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AutenticacaoAspNet.Models
{
    public class UsuariosContext: DbContext
    {
        public UsuariosContext() : base("Usuarios")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
using EstudandoEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EstudandoEntity.Infra
{
    public class EntidadesContext : DbContext
    {        
        public DbSet<Usuario> Usuarios { get; set; }

        public EntidadesContext(string conexao) : base(conexao)
        {
            Database.SetInitializer<EntidadesContext>(null);
        }
    }
}

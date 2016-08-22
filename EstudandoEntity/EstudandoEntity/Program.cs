using EstudandoEntity.Entidades;
using EstudandoEntity.Infra;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            string conexao = ConfigurationManager.ConnectionStrings["LojaConnectionString"].ConnectionString;
            EntidadesContext contexto = new EntidadesContext(conexao);
            Usuario renan = new Usuario()
            {
                Nome = "Renan",
                Senha = "123"
            };
            contexto.Usuarios.Add(renan);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}

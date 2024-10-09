using FrontEnd_SIGA;
using FrontEnd_SIGA.Entidades;
using FrontEnd_SIGA.Layout;
using FrontEnd_SIGA.Pages;
using System.Collections.Generic;
using System.Linq;

namespace FrontEnd_SIGA.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nome = "admin", Senha = "admin", Dados = "Dados do Admin" }
        };

        public Usuario Login(string nome, string senha)
        {
            return usuarios.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);
        }
    }
}


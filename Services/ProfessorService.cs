using FrontEnd_SIGA.Entidades;
using FrontEnd_SIGA.Pages;
using FrontEnd_SIGA.Layout;
using System.Collections.Generic;
using System.Linq;

namespace CadastroProfessores.Services
{
    public class ProfessorService
    {
        private List<Professor> Professores = new List<Professor>();

        public List<Professor> GetProfessores()
        {
            return Professores;
        }

        public void AddProfessor(Professor professor)
        {
            professor.Id = Professores.Count + 1;
            Professores.Add(professor);
        }
    }
}





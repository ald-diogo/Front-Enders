using FrontEnd_SIGA;
using FrontEnd_SIGA.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace CadastroNotasEstudantes.Services
{
    public class EstudanteService
    {
        private List<Estudante> Estudantes = new List<Estudante>();

        public List<Estudante> GetEstudantes()
        {
            return Estudantes;
        }

        public void AddEstudante(Estudante estudante)
        {
            estudante.Id = Estudantes.Count + 1;
            Estudantes.Add(estudante);
        }

        private List<Estudante> estudantes = new List<Estudante>
        {
            new Estudante { Id = 1, Nome = "", Curso = "" },
            new Estudante { Id = 2, Nome = "", Curso = "" },
            new Estudante { Id = 3, Nome = "", Curso = "" }
        };

        public double CalcularMedia(Estudante estudante)
        {
            return estudante.Notas.Average();
        }

        public (double media, double mediana, double desvioPadrao) CalcularEstatisticas(Estudante estudante)
        {
            var notas = estudante.Notas;
            var media = notas.Average();
            var mediana = notas.OrderBy(n => n).ElementAt(notas.Count / 2);
            var desvioPadrao = Math.Sqrt(notas.Average(v => Math.Pow(v - media, 2)));
            return (media, mediana, desvioPadrao);
        }

        public void AddEstudantes(Estudante estudante) => estudantes.Add(estudante);

        public void EnviarNotificacao(string mensagem)
        {
            foreach (var estudante in estudantes)
            {
                // Lógica para enviar notificação (e.g., via email)
                Console.WriteLine($"Enviando notificação para {estudante.Email}: {mensagem}");
            }
        }
    }
}



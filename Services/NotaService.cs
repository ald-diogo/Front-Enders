using FrontEnd_SIGA.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace CadastroNotasEstudantes.Services
{
    public class NotaService
    {
        private List<Nota> Notas = new List<Nota>();

        public List<Nota> GetNotas()
        {
            return Notas;
        }

        public void AddNota(Nota nota)
        {
            nota.Id = Notas.Count + 1;
            Notas.Add(nota);
        }

        public double CalcularMedia(int estudanteId)
        {
            var notas = Notas.Where(n => n.EstudanteId == estudanteId).Select(n => n.Valor);
            return notas.Any() ? notas.Average() : 0;
        }

        public double ObterMaiorNota(int estudanteId)
        {
            var notas = Notas.Where(n => n.EstudanteId == estudanteId).Select(n => n.Valor);
            return notas.Any() ? notas.Max() : 0;
        }

        public double ObterMenorNota(int estudanteId)
        {
            var notas = Notas.Where(n => n.EstudanteId == estudanteId).Select(n => n.Valor);
            return notas.Any() ? notas.Min() : 0;
        }

        public string ObterStatus(int estudanteId)
        {
            var media = CalcularMedia(estudanteId);
            if (media >= 9.5)
                return "Apto";
            else if (media <= 9)
                return "Recurso";
            else
                return "Reprovado";
        }
    }

}


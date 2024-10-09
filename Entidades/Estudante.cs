namespace FrontEnd_SIGA.Entidades
{
    public class Estudante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Morada { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public List<double> Notas { get; set; }
    }
}

namespace Api_Postgres_.Models
{
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string imagemFoto { get; set; }
        public DateTime nascimento { get; set; }
    }
}

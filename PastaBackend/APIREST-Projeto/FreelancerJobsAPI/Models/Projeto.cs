namespace FreelancerJobsAPI.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}

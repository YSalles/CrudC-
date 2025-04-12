namespace CrudPessoa.Models
{
    public class Pessoa
    {
        // atributos da minha classe de pessoa
        public int Id { get; set; }

        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }

        // construtor da minha classe de pessoa
        public Pessoa(int id, string? nome, string? email, string? cpf)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
        }
    }
}
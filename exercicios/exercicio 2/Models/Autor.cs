namespace Models
{
    class Autor
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Autor(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }
}
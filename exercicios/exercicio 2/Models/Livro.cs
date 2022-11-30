namespace Models
{
    class Livro
    {
        public string Nome { get; private set; }
        public List<Autor> Autores { get; set; }

        public Livro(string nome, Autor autor)
        {
            this.Nome = nome;
            this.Autores = new List<Autor>(){autor};
        }

        public Livro(string nome, List<Autor> autores)
        {
            this.Nome = nome;
            this.Autores = autores;
        }

        public override string ToString()
        {
            string autores = "";
            foreach (var autor in this.Autores)
            {
                if(this.Autores.IndexOf(autor) == this.Autores.Count - 1) {
                    autores += autor.Nome;
                     return $"Nome do livro: {this.Nome} - Autores: {autores}";
                } 
                autores += autor.Nome + " - ";
            }
            return $"Nome do livro: {this.Nome} - Autores: {autores}";
        }
    }
}
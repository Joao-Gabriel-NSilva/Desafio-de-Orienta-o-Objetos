namespace Models
{
    class Animal
    {
        public string Raca { get; private set; }
        public string Tamanho { get; private set; }
        public virtual void EmitirSom() { 
            Console.WriteLine("Emitindo som de animal");
        }

        public Animal(string raca, string tamanho)
        {
            this.Raca = raca;
            this.Tamanho = tamanho;
        }
    }
}

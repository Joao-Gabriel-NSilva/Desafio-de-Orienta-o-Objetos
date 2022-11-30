namespace Models
{
    class Gato : Animal
    {
        public Gato(string raca, string tamanho) : base(raca, tamanho)
        {
            
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som de gato");
        }
    }
}
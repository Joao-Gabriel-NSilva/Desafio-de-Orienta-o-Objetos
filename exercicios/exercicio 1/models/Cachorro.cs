namespace Models
{
    class Cachorro : Animal
    {
        public Cachorro(string raca, string tamanho) : base(raca, tamanho)
        {
            
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som de cachorro");
        }
    }
}
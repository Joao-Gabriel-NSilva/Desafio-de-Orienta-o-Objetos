namespace Models
{
    class Passaro : Animal
    {
        public Passaro(string raca, string tamanho) : base(raca, tamanho)
        {
            
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som de passaro");
        }
    }
}
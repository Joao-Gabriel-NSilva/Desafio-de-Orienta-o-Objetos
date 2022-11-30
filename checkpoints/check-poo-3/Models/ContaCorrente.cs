using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula05.Interfaces;

namespace Aula05.Models
{
    public class ContaCorrente : Conta, IConta
    {
        public double Tarifa { get; set; }

        public override void ExibirTipoDeConta()
        {
            base.ExibirResumoConta();
            Console.WriteLine("Conta Corrente");
        }

        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta();
            Console.WriteLine($"Tarifa: {Tarifa}");
        }

        public void EncerrarConta()
        {
            Console.WriteLine("Encerrando a conta corrente");
        }
    }
}
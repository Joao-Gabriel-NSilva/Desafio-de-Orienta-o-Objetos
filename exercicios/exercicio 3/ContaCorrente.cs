class ContaCorrente
{
    public string NomeCorrentista { get; set; }
    public int NumeroConta { get; private set; }
    public int NumeroAgencia { get; private set; }
    public double Saldo { get; private set; }

    public ContaCorrente(string nomeCorrentista, int numConta, int numAgencia, double saldo)
    {
        this.NomeCorrentista = nomeCorrentista;
        this.NumeroConta = numConta;
        this.NumeroAgencia = numAgencia;
        this.Saldo = saldo;
    }

    public bool Deposita(double valor)
    {
        if (valor < 0)
        {
            return false;
        }
        this.Saldo += valor;
        return true;
    }

    public bool Saca(double valor)
    {
        if (valor > this.Saldo | valor < 0)
        {
            return false;
        }
        this.Saldo -= valor;
        return true;
    }
}
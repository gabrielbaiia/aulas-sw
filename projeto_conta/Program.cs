namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROJETO BANCO ETEC MCM");
        Conta c = new Conta();
        //c.Saldo = 1000;
        c.Depositar(1000);
        //c.Limite = 500;
        c.Sacar(2000);
        c.AjustarLimite(500);

        double valorTotal = c.MostrarSaldo();

        //Console.WriteLine("Seu saldo é de: "+ c.Saldo + " com limite de: " + c.Limite);

        Console.WriteLine("Seu saldo total é: " + valorTotal);
        //Console.WriteLine("Seu saldo total é: " + c.Saldo);
    }
}
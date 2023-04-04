namespace projeto_conta;
class Conta
{
    public int Numero {get;set;} 
    public double Saldo {get; private set;}
    public double Limite {get;set;}

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }


    public void Depositar(double valor){
        this.Saldo+=valor;
    }

     public void Sacar(double valor){
        this.Saldo-=valor;

        if(valor <- this.Saldo + this.Limite){
            this.Saldo -= valor;
        }
        else{
           Console.WriteLine("Voce não possui saldo suficiente para fazer esse saque");
        }
    }

    public double MostrarSaldo(){

        return this.Saldo + this.Limite;

    }


}
namespace exemplo;
class Aviao
{
    public string modelo="";
    public string marca="";
     public int velocidade;
     public int altitude;

     public void acelerar(){
        Console.WriteLine ("Estou acelerando!!");
     }

      public void acelerarParametro(string valor){
        Console.WriteLine ("Estou acelerando!!" + valor);
     }

    public string potato(){
        return "Ai preto";
    }

    public int somar(int a, int b){
        return a+b;
    }


}

namespace projeto_pessoa;
class Pessoa
{
    public Pessoa(){
        this.Nome = "NÃo INFORMADO";
        this.SobreNome = "NÃO INFORMADO";
        this.Idade = 0;

    }

    public Pessoa(string nome, int Idade){
        this.Nome = nome;
        this.Idade = Idade;
        this.SobreNome = "Não Informado";

    }

    private string? Nome{get;set;}
    private string? SobreNome{get; set;}
    private int Idade {get; set;}

    public void InsereNome(string nome){
        this.Nome = nome;
    }

     public void InsereSobreNOme(string sobrenome){
        this.SobreNome = sobrenome;
    }

     public void InsereIdade(int idade){
        this.Idade = idade;
    }

    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
         Console.WriteLine("SobreNome: " + this.SobreNome);
          Console.WriteLine("Idade: " + this.Idade);
    }
}

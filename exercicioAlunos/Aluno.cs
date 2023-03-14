namespace exercicioAlunos;
class Alunos 
{
    public string nome= "";

    public double nota1, nota2;

    //MEDIA -> retorna um double (por exemplo um numero como 8.3)
    public double obterMedia (){
        double media = (nota1+nota2)/2;
        return media;
    }

    //SITUAÇÃO -> retorna uma string ("aprovado" ou "reprovado")

    public string obterSituacao (double media){
        string situacao="";
        if (media>=6){
            situacao="Aprovado";
        }else{
            situacao="reprovado";
        }
        return situacao;
    }

    //MENSAGEM -> nao retorna nada, so mostra na tela os detalhes (nome, media e situação)

    public void mensagem(){
        double mediaCalculada = obterMedia ();
        string resultadoSituacao = obterSituacao (mediaCalculada);
        Console.WriteLine (nome+" esta "+ resultadoSituacao +" com media "+mediaCalculada);
    }

}
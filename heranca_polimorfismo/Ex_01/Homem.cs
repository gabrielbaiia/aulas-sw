namespace ex_01;

class Homem:Animal
{
    public override string Fala()
    {
        return base.Fala() + ("Olá!");
    }
}

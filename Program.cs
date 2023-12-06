using System;

class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

class Subclasse : Personagem
{
    public int DanoBase { get; set; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        DanoBase = danoBase;
    }

    public int CalcularDano(int quantidadeMana)
    {
        return DanoBase * quantidadeMana;
    }
}

class Program
{
    static void Main()
    {

        string nome = Console.ReadLine();


        int mana = int.Parse(Console.ReadLine());


        int danoBase = int.Parse(Console.ReadLine());


        Subclasse personagemSubclasse = new Subclasse(nome, mana, danoBase);


        int quantidadeManaAtaque = int.Parse(Console.ReadLine());


        int danoCausado = personagemSubclasse.CalcularDano(quantidadeManaAtaque);
        Console.WriteLine($"{personagemSubclasse.Nome} atacou e causou {danoCausado} de dano!");
    }
}
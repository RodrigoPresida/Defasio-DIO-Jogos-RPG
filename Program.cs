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
    public void CalcularDano(int quantidadeMana)
    {
        int danoCausado = DanoBase * quantidadeMana;
        Console.WriteLine($"{Nome} atacou e causou {danoCausado} de dano!");
    }
}

class Program
{
    static void Main()
    {
        string nomePersonagem = Console.ReadLine();


        if (int.TryParse(Console.ReadLine(), out int quantidadeMana) && int.TryParse(Console.ReadLine(), out int danoBase))
        {
            Subclasse personagemSubClasse = new Subclasse(nomePersonagem, quantidadeMana, danoBase);

            personagemSubClasse.CalcularDano(quantidadeMana);

        }

    }
}
using System;
using ex1;

jogo jogo = new jogo();


do
{
    try
    {


        Console.WriteLine("id do jogo");
        jogo.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("nome do jogo");
        jogo.Nome = Console.ReadLine();

        Console.WriteLine("data de lancamento");
        jogo.Lancamento = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("categoria");
        jogo.Categoria = Console.ReadLine();



    }
    catch (Exception erro)
    {
        Console.WriteLine(erro.Message);
    }
} while (true);



Console.WriteLine(jogo.ToString());



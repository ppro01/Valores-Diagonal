using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] NumTab = new int[5, 5];

        NumTab = Tab();


        Console.Write("{0} {1} {2} {3} {4} {5} {6} {7} {8}", NumTab[0, 0], NumTab[0, 4], NumTab[1, 1], NumTab[1, 3], NumTab[2, 2], NumTab[3, 1], NumTab[3, 3], NumTab[4, 0], NumTab[4, 4]);
        Console.ReadKey();
    }
    static int[,] Tab()
    {
        int[,] Value = new int[5, 5];
        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                Console.Write("Linha {0} Coluna {1}: ", linha, coluna);
                Value[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        return Value;
    }
}
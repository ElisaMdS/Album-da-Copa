using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
        int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
        //int totalDeFigurinhasQueFaltam = 0;

        var listaDeFigurinhasNaoRepetidas = new List<int>();

        for (int i = 0; i < numeroDeFigurinhasCompradas; i++) {

            var figurinhaAtual = Int32.Parse(Console.ReadLine());
            
            if (!listaDeFigurinhasNaoRepetidas.Contains(figurinhaAtual)) listaDeFigurinhasNaoRepetidas.Add(figurinhaAtual);

        }

        Console.WriteLine(numeroDeFigurinhas - listaDeFigurinhasNaoRepetidas.Count);

        //int[] albumDeFigurinha = new int[numeroDeFigurinhas];
        // IMPLEMENTE AQUI A SOLUÇÃO

        /*int[] figurinhasObtidas = new int[numeroDeFigurinhasCompradas];

        for (int populaFigurinhasObtidas = 0; populaFigurinhasObtidas <= figurinhasObtidas.Length - 1; populaFigurinhasObtidas++)
        {

            if (numeroDeFigurinhasCompradas == 1)
            {

                Console.WriteLine(numeroDeFigurinhas - 1);
                return;

            }
            else figurinhasObtidas[populaFigurinhasObtidas] = Int32.Parse(Console.ReadLine());

        }

        int figurinhasRepetidas = 0;

        /* for (int verificaFigurinhasRepetidas = 0; verificaFigurinhasRepetidas <= figurinhasObtidas.Length -1; verificaFigurinhasRepetidas++)
        {

            for (int verificaFigurinhasRepetidas2 = 1; verificaFigurinhasRepetidas2 <= figurinhasObtidas.Length - 1; verificaFigurinhasRepetidas2++)
            {

                if (figurinhasObtidas[verificaFigurinhasRepetidas] == figurinhasObtidas[verificaFigurinhasRepetidas2]) figurinhasRepetidas++;

            }
        } */


        /*for (int i = 0; i <= figurinhasObtidas.Length - 1; i++)
        {

            int proximo = i + 1;

            if (proximo < figurinhasObtidas.Length)
            {
                if (figurinhasObtidas[i] == figurinhasObtidas[proximo]) figurinhasRepetidas++;

            }
        }

        /*int figurinhasDiferentes = 0;

        for (int i = 0; i <= figurinhasObtidas.Length - 1; i++)
        {

            int proximo = i + 1;

            if (proximo < figurinhasObtidas.Length)
            {
                if (figurinhasObtidas[i] != figurinhasObtidas[proximo]) figurinhasDiferentes++;

            }
        }*/

        //totalDeFigurinhasQueFaltam = numeroDeFigurinhas - (numeroDeFigurinhasCompradas - (figurinhasRepetidas > 1 ? ++figurinhasRepetidas : figurinhasRepetidas));
        //totalDeFigurinhasQueFaltam = numeroDeFigurinhas - figurinhasRepetidas;

        //Console.WriteLine(totalDeFigurinhasQueFaltam);
    }
}
using System;

class URI
{

    static void Main(string[] args)
    {
        int XImpar, YImpar, i, menor, maior,soma,valor1,valor2;
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        // determinar o numero maior entre X e Y
        soma = 0;
        valor1 = 0;
        valor2 = 0;
        if (X > Y)
        {
            maior = X;
            menor = Y;
        }
        else
        {
            maior = Y;
            menor = X;
        }

       
        for (i=menor+1; i<maior; i++)
        {

            if (i % 2 != 0)
            {
                
                soma=i;
            }
        }
        Console.WriteLine(soma);
    }
}
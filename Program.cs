using System;

class URI
{

    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int Resto,maior, menor,Soma;
        Soma = 0;
        if (X > Y)
        {
            maior = X;
            menor = Y;
        }
        else
            menor = X;
        maior = X;
        do
        {
           
            Resto = menor % 2;
            if (Resto==0)
            menor++;
            else
                Soma = menor + Soma;
            menor++;
        }
        while (menor < maior);
        Console.WriteLine(Soma);

    }
}


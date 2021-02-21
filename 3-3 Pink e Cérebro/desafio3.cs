using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int pinkDuvida = Convert.ToInt32(Console.ReadLine());

        List<int> numeros = new List<int>();

        var lista = Console.ReadLine().Split(" ").ToList();

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;

        foreach (var item in lista)
        {
            var numero = Convert.ToInt32(item);

            if (numero % 2 == 0) multiplo2++;
            if (numero % 3 == 0) multiplo3++;
            if (numero % 4 == 0) multiplo4++;
            if (numero % 5 == 0) multiplo5++;
        }

        Console.WriteLine($"{multiplo2} Multiplo(s) de 2");
        Console.WriteLine($"{multiplo3} Multiplo(s) de 3");
        Console.WriteLine($"{multiplo4} Multiplo(s) de 4");
        Console.WriteLine($"{multiplo5} Multiplo(s) de 5");
    }
}
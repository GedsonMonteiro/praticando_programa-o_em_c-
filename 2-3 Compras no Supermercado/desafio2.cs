using System;
using System.Collections.Generic;

class MinhaClasse {
  public static void Main (string[] args) {    
    int limit = int.Parse(Console.ReadLine());
            List<string> lista = new List<string>();
            for (int i = 0; i < limit; i++)
            {
                if (i > 100) return;
                string[] line = Console.ReadLine().Split(" ");

                for (int item = 0; item < line.Length; item++)
                {
                    if (item > 1000) return;
                    if (!lista.Contains(line[item]))
                    {
                        lista.Add(line[item]);
                    }
                }
                
                lista.Sort();
                Console.WriteLine(string.Join(" ", lista));
                lista.Clear();
            }
  }
}
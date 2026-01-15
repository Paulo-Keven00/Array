namespace AULA_4;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome dos alunos:");
        string[] nomes = new string[3];

        for(int i=0; i < nomes.Length; i++)
        {
            nomes[i] = Console.ReadLine();
        }
        Console.WriteLine("Os alunos são:");
        foreach(string n in nomes)
        {
            Console.Write(n+", ");
        }
        
    }
}

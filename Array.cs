namespace LEARNING_ARRAY;

using System;
class Array
{
    static void Main(string[] args)
    {
        Licao1();
    }
    static void Licao1()
    {
        //crie um array de 5 numeros inteiros
        //Peça ao usuario para digitar os valores
        //No final, mostre todos na tela

        int[] num = new int[5];

        for(int i=0;i < num.Length; i++)
        {
            Console.Write($"Digite o valor {i+1}: ");
            if(int.TryParse(Console.ReadLine(), out num[i]))
            {
                Console.WriteLine(num[i]);
            }
            else
            {
                Console.WriteLine("Valor invalido! Apenas números são aceitos");
            }
        }
        Console.Write($"Valores digitados foram: ");
        for(int x=0;x < num.Length; x++)
        {
            Console.Write(num[x]+", ");
        }
        
    }
}

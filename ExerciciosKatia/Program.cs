using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosKatia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            
            int idade;
            string sexo;
            Console.WriteLine("Informe o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe seu sexo");
            sexo = Console.ReadLine();

            if (sexo.Equals("Feminino"))
            {
                if (idade >= 18 && idade <= 25)
                {
                    string desconto = "4%";
                    Console.WriteLine($"O desconto foi de {desconto} ");
                }
                else if (idade >= 26 && idade <= 55)
                {
                    string desconto = "7%";
                    Console.WriteLine($"O desconto foi de {desconto} ");
                }
                else if (idade > 55)
                {
                    string desconto = "10%";
                    Console.WriteLine($"O desconto foi de {desconto} ");
                }
            }
            else
            {
                if (sexo.Equals("Masculino"))
                {
                    if (idade >= 18 && idade <= 25)
                    {
                        string desconto = "3%";
                        Console.WriteLine($"O desconto foi de {desconto} ");
                    }
                    else if (idade >= 26 && idade <= 55)
                    {
                        string desconto = "6%";
                        Console.WriteLine($"O desconto foi de {desconto} ");
                    }
                    else if (idade > 55)
                    {
                        string desconto = "9%";
                        Console.WriteLine($"O desconto foi de {desconto} ");
                    }
                }
            }
            Console.ReadKey();  
        }
    }
}

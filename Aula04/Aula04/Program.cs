using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Digite o seu nome: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Digite sua idade: ");
            age = Convert.ToInt32(Console.ReadLine());

            int days = age * 365;
            Console.WriteLine("Olá {0}, você já viveu {1} dias.", name, days);
            Console.ReadLine();
        }
    }
}
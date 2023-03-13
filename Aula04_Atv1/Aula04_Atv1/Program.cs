namespace Aula04_Atv1
{
    //Classe
    class Program
    {
        //Método principal
        static void Main(string[] args)
        {
            //Somar dois números
            int a, b, result;

            Console.Write("Digite o número 1: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            result = a + b;
            Console.WriteLine("A soma de {0} e {1} é {2}", a, b, result);
            Console.ReadLine();
        }
    }
}
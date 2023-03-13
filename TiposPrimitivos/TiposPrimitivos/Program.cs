namespace TiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos Primitivos");

            string nome = "José";
            int numero = 20;
            long numeroGrande = 120000000;
            byte item = 20;

            double comissao = 32.45213415521521;
            decimal valor = 1000.56m; //convertendo para decimal com a letra M

            DateTime data = DateTime.Now;
            DateTime exemplo = new DateTime(2015, 12, 31);
            Console.WriteLine(data);
            Console.WriteLine(exemplo);
            

        }
    }
}
string senha = "123";
string senhaInformada = string.Empty;

do
{
    Console.Write("Digite a senha: ");
    senhaInformada = Console.ReadLine();

    if(senhaInformada != senha)
    {
        Console.WriteLine("Senha incorreta.");
    }

} while (senhaInformada != senha);

/*int x = 1;

while (x <= 10)
{
    Console.WriteLine(x);
    x++;   
}
*/

/*string senha = "123";
string senhaInformada = string.Empty;

while (senha != senhaInformada)
{
    Console.Write("Digite a senha: ");
    senhaInformada = Console.ReadLine();
}
*/

/*for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/
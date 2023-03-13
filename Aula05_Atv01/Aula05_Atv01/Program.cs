Console.Write("Digite o valor do produto: ");
decimal valor = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quantidade: ");
int qtd = Convert.ToInt32(Console.ReadLine());

decimal resultado = qtd * valor;
Console.WriteLine("O valor total é: {0:c}", resultado); //a letra c Formata para o formato da moeda

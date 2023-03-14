//Formas de pagamento
//Se o valor da compra for maior que 1000.00 reais, pode parcelar em 3 vezes
//Se não for, apenas a vista

decimal valorCompra;
int numeroParcelas = 3;
decimal valorParcela;
decimal ValorMinimoParcela = 1000.01m;

Console.Write("Digite o valor da compra: ");
valorCompra = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Valor a vista: {0:c}", valorCompra);

if (valorCompra >= ValorMinimoParcela)
{
    valorParcela = valorCompra / numeroParcelas;
    Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da parcela: {1:c}", numeroParcelas, valorParcela);
}
//arrays 

int[] numeros = new int[6];
numeros[0] = 40;
numeros[1] = 5;
numeros[2] = 43;
numeros[3] = 17;
numeros[4] = 52;
numeros[5] = 10;

//Percorrendo
foreach  (int n in numeros)
{
    Console.WriteLine(n);
}

//Ordenar
Array.Sort(numeros);

//Pesquisar
int indice = Array.IndexOf(numeros, 40);
if(indice == -1)
{
    Console.WriteLine("17 não encontrado");
} else
{
    Console.WriteLine("Econtrado:{0} na posição {1}", numeros[indice], indice);
}

Console.WriteLine("-----");

foreach (int n in numeros)
{
    Console.WriteLine(n);
}
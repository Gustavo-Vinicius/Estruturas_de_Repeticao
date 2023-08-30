Console.WriteLine("Digite a quantidade de números: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

long[] numeros = new long[quantidade];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i <  numeros.Length; i++)
{
    long resultado = 1;
    for (long y = numeros[i]; y > 0; y--)
    {
        resultado = y*resultado;
    }

    Console.WriteLine("O fatorial de "+ numeros[i] + " é: " + resultado);
}
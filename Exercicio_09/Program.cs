int numero;
int menor = int.MaxValue; // Inicializa com o maior valor possível
int maior = int.MinValue; // Inicializa com o menor valor possível

Console.WriteLine("Digite um conjunto de números positivos. Use um número negativo para encerrar.");

while (true)
{
    Console.Write("Digite um número: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero < 0)
        {
            break; // Sai do loop se for digitado um número negativo
        }

        if (numero < menor)
        {
            menor = numero; // Atualiza o menor número
        }

        if (numero > maior)
        {
            maior = numero; // Atualiza o maior número
        }
    }
    else
    {
        Console.WriteLine("Por favor, digite um número válido.");
    }
}

if (menor == int.MaxValue || maior == int.MinValue)
{
    Console.WriteLine("Nenhum número positivo foi digitado.");
}
else
{
    Console.WriteLine($"Menor número: {menor}");
    Console.WriteLine($"Maior número: {maior}");
}

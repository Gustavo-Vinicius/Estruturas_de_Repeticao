int numero = 0,
    resultado = 0;

do
{
    Console.WriteLine("Digite um número maior que 0 e menor que 10: ");
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero <= 0 || numero >= 10);
for (int i = numero; i < 40 + numero; i++)
{
    if (i % 2 == 1)
    {
        resultado += i * i;
    }
}
Console.WriteLine(
    "O resultado da soma dos quadrados dos 20 primeiros números inteiros positivos ímpares a partir do número informado é: "
        + resultado
);

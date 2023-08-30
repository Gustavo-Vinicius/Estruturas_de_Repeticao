int n = Convert.ToInt32(Console.ReadLine());
int formula,
    contador;

for (contador = 1; contador <= 10; ++contador)
{
    formula = n * contador;
    Console.WriteLine(n + " X " + contador + " = " + formula);
}

int totalAlunos = 0;
double somaNotas = 0;

Console.WriteLine("Calculadora de Média de Notas");
Console.WriteLine("Digite as notas dos alunos. Para sair, digite um número negativo.");

while (true)
{
    Console.Write("Número de matrícula do aluno: ");
    string matriculaInput = Console.ReadLine();

    if (!int.TryParse(matriculaInput, out int matricula) || matricula < 0)
    {
        break; // Sai do loop se o usuário digitar um número negativo ou um valor inválido.
    }

    Console.Write("Nota do aluno: ");
    if (double.TryParse(Console.ReadLine(), out double nota))
    {
        totalAlunos++;
        somaNotas += nota;
    }
    else
    {
        Console.WriteLine("Nota inválida. Tente novamente.");
    }
}

if (totalAlunos > 0)
{
    double media = somaNotas / totalAlunos;
    Console.WriteLine($"Média das notas dos {totalAlunos} alunos: {media:F2}");
}
else
{
    Console.WriteLine("Nenhum aluno foi inserido.");
}

public static class Atividade2Array
{
    public static void Executar ()
    {
int[] numeros = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.Write($"Digite o número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("\nNúmeros digitados:");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(numeros[i]);
}
    }
}
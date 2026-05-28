public static class Atividade6Array
{
    public static void Executar ()
    {
int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (numeros[i] > numeros[j])
        {
            int temp = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = temp;
        }
    }
}

Console.WriteLine("\nNúmeros ordenados:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(numeros[i]);
}
    }
}
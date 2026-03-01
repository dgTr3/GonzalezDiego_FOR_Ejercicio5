Console.WriteLine("Mostrar una tabla de multiplicar del 1 al 5 (todas juntas).");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
Int32 numero1, numero2, numero3;

Console.WriteLine("Digite o primeiro núnmero: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo núnmero: ");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro núnmero: ");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine("Maior número: " +  numero1);
}
else if (numero2 > numero3)
{
    Console.WriteLine("Maior número: " + numero2);
}
else
{
    Console.WriteLine("Maior número: " + numero3);
}

if (numero1 < numero2 && numero1 < numero3)
{
    Console.WriteLine("Menor número: " + numero1);
}
else if (numero2 < numero3)
{
    Console.WriteLine("Menor número: " + numero2);
}
else
{
    Console.WriteLine("Menor número: " + numero3);
}
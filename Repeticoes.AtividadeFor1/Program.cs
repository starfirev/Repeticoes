// Peça um número inteiro positivo e exiba sua tabuada de 1 a 10.

Console.WriteLine("Coloque um número inteiro:");
var numero  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---Tabuada---");

for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {contador * numero}");
    Thread.Sleep(500);
}
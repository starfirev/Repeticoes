int dia = 1;
int total = 0;

while (dia < 11)
{
    total = total + 5;
    Console.WriteLine($"Dia {dia}: R${total}");
    dia++;
    Thread.Sleep(1000);
}
Console.WriteLine("Economia total concluída com sucesso!");


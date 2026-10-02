int contador  = 5;

while (contador > 0)
{
    Console.WriteLine($"Contagem regressiva: {contador}");
    contador--;
    Thread.Sleep(1000);
}

Console.WriteLine("Foguete lançado com sucesso!");
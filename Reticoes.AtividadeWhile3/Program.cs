Console.WriteLine("digite a senha de acesso:");
string senhaCorreta = "programadora2026";
string senhaUsuario = Console.ReadLine();
while (senhaUsuario != senhaCorreta)
{
    Console.WriteLine("Senha incorreta! Tente novamente:");
    senhaUsuario = Console.ReadLine();
}

Console.WriteLine("Acesso liberado! Bem-vinda ao sistema!");
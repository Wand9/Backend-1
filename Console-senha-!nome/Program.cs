Console.WriteLine($"Digite seu nome de usuario: ");
string usuario = (Console.ReadLine());

Console.WriteLine($"Digite sua senha: ");
string senha = (Console.ReadLine());

while (usuario == senha)
{
    Console.WriteLine($"A senha nao pode ser igual ao nome de usuario!");
    senha = Console.ReadLine();
}
Console.WriteLine($"Senha aceita! ");
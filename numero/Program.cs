Console.WriteLine($"Informe sua nota: (Nota entre 0 e 10)");
string nota = Console.ReadLine();

while (nota.Length <10)
{
    Console.WriteLine($"Digite a nota dentro do permitido (Nota entre 0 e 10!): ");
    nota = Console.ReadLine();     
}
Console.WriteLine($"Nota aceita");
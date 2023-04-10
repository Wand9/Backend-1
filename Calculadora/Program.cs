System.Console.WriteLine(@$"
------------------------------------------------------
|Escolha uma operação matemática que deseja efetuar: |
|'+' para somar                                      |
|'*' para multiplicar                                |
|'-' para subtrair                                   |
|'/' para dividir                                    |
------------------------------------------------------
");

char operação = char.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro numero: ");
float numero1 = float.Parse(Console.ReadLine());

System.Console.WriteLine($"Digite o segundo numero: ");
float numero2 = float.Parse(Console.ReadLine());

float resultado = 0;

switch (Operacao)

    case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da soma é (resultado)");
        break;
    case '*':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da soma é (resultado)");
        break;
    case '-':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da soma é (resultado)");
        break;
    case '/':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da soma é (resultado)");
        break;
    default:
        Console.WriteLine($"A operação informada não é suportada pela nossa calculadora!");
        break;
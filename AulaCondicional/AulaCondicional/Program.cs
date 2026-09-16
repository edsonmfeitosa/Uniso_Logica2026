//Ordenação de 2 números inteiros
int numero1, numero2, menor, maior;
Console.WriteLine("Digite o primeiro número inteiro:");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número inteiro:");
numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 < numero2)
{
    menor = numero1;
    maior = numero2;
}
else
{
    menor = numero2;
    maior = numero1;
}

Console.WriteLine(menor + " - " + maior);
/*
    E - &&
    OU - ||
    Não = !
*/
//exemplo de switch case
switch(numero1)
{
    case 1:
        Console.WriteLine("Número 1");
        break;
    case 2:
        Console.WriteLine("Número 2");
        break;
    default:
        Console.WriteLine("Número diferente de 1 e 2");
        break;
}
//Usuário digita o número e mostra a tabuada de 1 a 10 do número digitado.
int numero;
int cont = 1;
Console.WriteLine("Digite um número para ver a tabuada:");
numero = int.Parse(Console.ReadLine());

while (cont <= 10)
{
    Console.WriteLine($"{numero} x {cont} = {numero * cont}");
    cont++;
}
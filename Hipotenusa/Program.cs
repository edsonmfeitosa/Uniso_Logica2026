double cat1;
double cat2;
double hipo;

//Escreva("Digite o 1º cateto")
Console.WriteLine("Digite o 1º cateto");
//Leia(cat1)
cat1 = Convert.ToDouble(Console.ReadLine());

//Escreva("Digite o 2º cateto")
Console.WriteLine("Digite o 2º cateto");
//Leia(cat2)
cat2 = Convert.ToDouble(Console.ReadLine());

//hipo = raiz(cat1² + cat2²)
// ^ significa "elevado a" no C# Math.Pow
//Math.Sqrt = raiz quadrada
hipo = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));

//Escreva("A hipotenusa é: " + hipo)
Console.WriteLine("A hipotenusa é: " + hipo);
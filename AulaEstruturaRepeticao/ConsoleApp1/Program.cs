//Aula de estrutura de Repetição

//Exemplo de estrutura Enquanto (While)
int contador = 1;
while (contador < 11)
{
    Console.WriteLine("Número " + contador);
    //contador++;
    contador = contador + 1;
}

//Exemplo de estrutura Faça Enquanto (Do While)
contador = 1;
do
{
    Console.WriteLine("Número " + contador);
    contador++;
} while (contador < 11);

//Exemplo de estrutura Para (For)
for (int i = 1; i < 11; i++)
{
    Console.WriteLine("Número " + i);
}

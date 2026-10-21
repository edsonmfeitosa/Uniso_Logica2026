// Exemplos de vetores e matrizes em C#
string[] nomes = new string[5]; // Declaração de um vetor de strings com 5 elementos

nomes[0] = "Edson";
nomes[1] = "Renata";
nomes[2] = "Victor";
nomes[3] = "Vinícius";
nomes[4] = "Yasmin";

Console.WriteLine("O primeiro nome é: " + nomes[0]);

//exemplo de for para correr o vetor de números
int[] numeros = new int[20]; // Declaração de um vetor de inteiros com 5 elementos
/*for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
*/
// exemplo de matriz de inteiros 2x3
int[,] matriz = new int[4, 3]; // Declaração de uma matriz de inteiros com 2 linhas e 3 colunas]
for (int linha = 0; linha < 4; linha++)
{
    for(int coluna = 0; coluna < 3; coluna++)
    {
        Console.WriteLine($"Digite o valor para a posição [{linha}, {coluna}]: ");
        matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
    }
}

// exemplo da matriz de inteiros montada na tela
for (int linha = 0; linha < 4; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write(matriz[linha, coluna] + "\t");
    }
    Console.WriteLine();
}
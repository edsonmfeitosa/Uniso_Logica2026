const int tamanho = 5;
const int quantidadeBombas = 5;

char[,] tabuleiroReal = new char[tamanho, tamanho];
char[,] tabuleiroVisivel = new char[tamanho, tamanho];
bool[,] revelado = new bool[tamanho, tamanho];

InicializarTabuleiro(tabuleiroReal, tabuleiroVisivel);
PosicionarBombas(tabuleiroReal, quantidadeBombas);

int celulasSeguras = (tamanho * tamanho) - quantidadeBombas;
int celulasReveladas = 0;
bool perdeu = false;

while (!perdeu && celulasReveladas < celulasSeguras)
{
    Console.Clear();
    ExibirTabuleiro(tabuleiroVisivel);

    int linha = LerPosicao("Digite a linha (1 a 5): ", tamanho) - 1;
    int coluna = LerPosicao("Digite a coluna (1 a 5): ", tamanho) - 1;

    if (revelado[linha, coluna])
    {
        Console.WriteLine("Essa posição já foi revelada. Pressione ENTER para continuar...");
        Console.ReadLine();
        continue;
    }

    revelado[linha, coluna] = true;

    if (tabuleiroReal[linha, coluna] == 'X')
    {
        tabuleiroVisivel[linha, coluna] = 'X';
        perdeu = true;
    }
    else
    {
        int bombasAoRedor = ContarBombasAoRedor(tabuleiroReal, linha, coluna);
        tabuleiroVisivel[linha, coluna] = char.Parse(bombasAoRedor.ToString());
        celulasReveladas++;
    }
}

Console.Clear();

if (perdeu)
{
    RevelarBombas(tabuleiroReal, tabuleiroVisivel);
    ExibirTabuleiro(tabuleiroVisivel);
    Console.WriteLine("Você perdeu! Encontrou uma bomba.");
}
else
{
    ExibirTabuleiro(tabuleiroVisivel);
    Console.WriteLine("Parabéns! Você venceu o jogo.");
}

void InicializarTabuleiro(char[,] real, char[,] visivel)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            real[i, j] = '0';
            visivel[i, j] = '.';
        }
    }
}

void PosicionarBombas(char[,] real, int totalBombas)
{
    Random random = new();
    int bombasColocadas = 0;

    while (bombasColocadas < totalBombas)
    {
        int linha = random.Next(tamanho);
        int coluna = random.Next(tamanho);

        if (real[linha, coluna] != 'X')
        {
            real[linha, coluna] = 'X';
            bombasColocadas++;
        }
    }
}

int LerPosicao(string mensagem, int limite)
{
    while (true)
    {
        Console.Write(mensagem);
        string? entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int valor) && valor >= 1 && valor <= limite)
        {
            return valor;
        }

        Console.WriteLine($"Entrada inválida. Digite um número de 1 a {limite}.");
    }
}

int ContarBombasAoRedor(char[,] real, int linha, int coluna)
{
    int total = 0;

    for (int i = linha - 1; i <= linha + 1; i++)
    {
        for (int j = coluna - 1; j <= coluna + 1; j++)
        {
            if (i >= 0 && i < tamanho && j >= 0 && j < tamanho && real[i, j] == 'X')
            {
                total++;
            }
        }
    }

    return total;
}

void RevelarBombas(char[,] real, char[,] visivel)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            if (real[i, j] == 'X')
            {
                visivel[i, j] = 'X';
            }
        }
    }
}

void ExibirTabuleiro(char[,] visivel)
{
    Console.WriteLine("    1 2 3 4 5");
    Console.WriteLine("   -----------");

    for (int i = 0; i < tamanho; i++)
    {
        Console.Write($"{i + 1} | ");

        for (int j = 0; j < tamanho; j++)
        {
            Console.Write(visivel[i, j]);
            Console.Write(' ');
        }

        Console.WriteLine();
    }
}

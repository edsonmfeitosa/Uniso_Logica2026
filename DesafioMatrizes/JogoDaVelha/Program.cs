const int tamanho = 3;
char[,] tabuleiro = new char[tamanho, tamanho];

InicializarTabuleiro(tabuleiro);

char jogadorAtual = 'X';
int jogadas = 0;
bool venceu = false;

while (!venceu && jogadas < tamanho * tamanho)
{
    Console.Clear();
    ExibirTabuleiro(tabuleiro);
    Console.WriteLine($"Jogador {jogadorAtual}, faça sua jogada.");

    int linha = LerPosicao("Digite a linha (1 a 3): ", tamanho) - 1;
    int coluna = LerPosicao("Digite a coluna (1 a 3): ", tamanho) - 1;

    if (tabuleiro[linha, coluna] != ' ')
    {
        Console.WriteLine("Essa posição já está ocupada. Pressione ENTER para tentar novamente...");
        Console.ReadLine();
        continue;
    }

    tabuleiro[linha, coluna] = jogadorAtual;
    jogadas++;

    if (VerificarVitoria(tabuleiro, jogadorAtual))
    {
        venceu = true;
    }
    else
    {
        jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
    }
}

Console.Clear();
ExibirTabuleiro(tabuleiro);

if (venceu)
{
    Console.WriteLine($"Jogador {jogadorAtual} venceu!");
}
else
{
    Console.WriteLine("Empate! Todas as posições foram preenchidas.");
}

void InicializarTabuleiro(char[,] matriz)
{
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            matriz[i, j] = ' ';
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

        Console.WriteLine($"Valor inválido. Digite um número de 1 a {limite}.");
    }
}

bool VerificarVitoria(char[,] matriz, char jogador)
{
    for (int i = 0; i < tamanho; i++)
    {
        if (matriz[i, 0] == jogador && matriz[i, 1] == jogador && matriz[i, 2] == jogador)
        {
            return true;
        }

        if (matriz[0, i] == jogador && matriz[1, i] == jogador && matriz[2, i] == jogador)
        {
            return true;
        }
    }

    if (matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador)
    {
        return true;
    }

    if (matriz[0, 2] == jogador && matriz[1, 1] == jogador && matriz[2, 0] == jogador)
    {
        return true;
    }

    return false;
}

void ExibirTabuleiro(char[,] matriz)
{
    Console.WriteLine("    1   2   3");

    for (int i = 0; i < tamanho; i++)
    {
        Console.Write($"{i + 1} ");

        for (int j = 0; j < tamanho; j++)
        {
            Console.Write($" {matriz[i, j]} ");

            if (j < tamanho - 1)
            {
                Console.Write("|");
            }
        }

        Console.WriteLine();

        if (i < tamanho - 1)
        {
            Console.WriteLine("   ---+---+---");
        }
    }
}

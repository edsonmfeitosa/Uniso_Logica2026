/*
 NÍVEL 1 – Jogo de Adivinhação com Tentativas Limitadas (Básico)
Regras
O computador sorteia um número entre 1 e 100.

O jogador tem 7 tentativas para acertar.

A cada tentativa, o programa diz se o palpite é maior ou menor que o número secreto.

Ao final, exibe quantas tentativas foram usadas.
*/
int numeroSecreto = new Random().Next(1, 101);
int tentativas = 7;
int palpite;
for (int i = 1; i <= tentativas; i++)
{
    Console.Write($"Tentativa {i}/{tentativas}: Digite um número entre 1 e 100: ");
    palpite = int.Parse(Console.ReadLine());
    if (palpite == numeroSecreto)
    {
        Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {i} tentativas.");
        break;
    }
    else if (palpite < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else
    {
        Console.WriteLine("O número secreto é menor.");
    }
    if (i == tentativas)
    {
        Console.WriteLine($"Suas tentativas acabaram! O número secreto era {numeroSecreto}.");
    }
}

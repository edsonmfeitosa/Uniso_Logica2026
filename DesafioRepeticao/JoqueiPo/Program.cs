/*
 NÍVEL 2 – Pedra, Papel, Tesoura: Melhor de 5 (Intermediário)
Regras
O jogador escolhe: 1) Pedra, 2) Papel, 3) Tesoura.

O computador escolhe aleatoriamente.

A cada rodada, exibe quem venceu.

O jogo vai até alguém vencer 3 rodadas.

Ao final, exibe o placar e o vencedor.
*/
int vitoriasJogador = 0;
int vitoriasComputador = 0;
while (vitoriasJogador < 3 && vitoriasComputador < 3)
{
    Console.WriteLine("Escolha: 1) Pedra, 2) Papel, 3) Tesoura");
    int escolhaJogador = int.Parse(Console.ReadLine());
    int escolhaComputador = new Random().Next(1, 4);
    Console.WriteLine($"Computador escolheu: {escolhaComputador}");
    if (escolhaJogador == escolhaComputador)
    {
        Console.WriteLine("Empate!");
    }
    else if ((escolhaJogador == 1 && escolhaComputador == 3) ||
             (escolhaJogador == 2 && escolhaComputador == 1) ||
             (escolhaJogador == 3 && escolhaComputador == 2))
    {
        Console.WriteLine("Você venceu esta rodada!");
        vitoriasJogador++;
    }
    else
    {
        Console.WriteLine("O computador venceu esta rodada!");
        vitoriasComputador++;
    }
}
Console.WriteLine($"Placar final: Jogador {vitoriasJogador} x {vitoriasComputador} Computador");
if (vitoriasJogador > vitoriasComputador)
{
    Console.WriteLine("Você venceu o jogo!");
}
else
{
    Console.WriteLine("O computador venceu o jogo!");
}   

/*
 Em um jogo, o jogador pode escolher uma classe digitando um número:
1: Guerreiro
2: Mago
3: Arqueiro
4: Ladino
Qualquer outro número: "Classe inválida"
*/
int opcao;
opcao = Convert.ToInt32(Console.ReadLine());
switch (opcao)
{
	case 1:
        Console.WriteLine("Você escolheu a classe Guerreiro.");
        break;
    case 2:
        Console.WriteLine("Você escolheu a classe Mago.");
        break;
    case 3:
        Console.WriteLine("Você escolheu a classe Arqueiro.");
        break;
    case 4:
        Console.WriteLine("Você escolheu a classe Ladino.");
        break;
    default:
		Console.WriteLine("Classe inválida.");
		break;
}
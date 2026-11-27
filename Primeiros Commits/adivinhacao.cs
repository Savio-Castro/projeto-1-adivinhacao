int limiteMaximo = 0;
int chances = 0;
bool jogarNovamente = true;

while(jogarNovamente == true)
{
    Console.Write("Digite um valor de 1 a 3 para escolher seu Nível ! ");
    int nivel =  Convert.ToInt16(Console.ReadLine());
    palpite = 0;
    switch(nivel)
{
    case 1:
    limiteMaximo = 10;
    chances = 5;
    Console.WriteLine("Você escolheu Nível 1");
    Console.WriteLine("Sua senha vai de 1 a 10 e tem até 5 tentativas !");
    Console.WriteLine(" ");
    break;

    case 2:
    limiteMaximo = 100;
    chances = 7;
    Console.WriteLine("Você escolheu Nível 2");
    Console.WriteLine("Sua senha vai de 1 a 100 e tem até 7 tentativas !");
    Console.WriteLine(" ");
    break;

    case 3:
    limiteMaximo = 1000;
    chances = 10;
    Console.WriteLine("Você escolheu Nível 3");
    Console.WriteLine("Sua senha vai de 1 a 1000 e tem até 10 tentativas !");
    Console.WriteLine(" ");
    break;

    default:
    Console.WriteLine("Valor Incorreto !!");
    break;

}

int secreto = Random.Shared.Next(1,limiteMaximo + 1);

while (palpite != secreto && chances > 0)
{
    Console.WriteLine("Digite um valor para o seu palpite: ");
    palpite = Convert.ToInt16(Console.ReadLine());

    if(palpite < 1 || palpite > limiteMaximo)
    {
        Console.WriteLine($"Você digitou um valor inválido");
    }

    else if(palpite > secreto )
    {
        Console.WriteLine($"Seu palpite foi {palpite}");
        Console.WriteLine($"Número é Menor ! ");
        chances--;
        Console.WriteLine($"Você ainda tem: {chances} chances");
        Console.WriteLine(" ");
    }
    else if (palpite < secreto)
    {
        Console.WriteLine($"Seu palpite foi {palpite}");
        Console.WriteLine($"Número Maior");
        chances--;
        Console.WriteLine($"Você ainda tem: {chances} chances");
        Console.WriteLine(" ");
    }

    else 
    {
        Console.WriteLine($"Parabéns você acertou o número");
        Console.WriteLine("Fim de Jogo");
    }
}

 if (secreto != palpite && chances == 0)
{
     Console.WriteLine($"Seu número de Chances acabaram o número secreto era: {secreto}");    
}

Console.WriteLine("--------------------------------------");
Console.WriteLine("Você desejar jogar novamente ? ");
Console.WriteLine("Se sim digite true senão digite false: ");
jogarNovamente = Convert.ToBoolean(Console.ReadLine());
}

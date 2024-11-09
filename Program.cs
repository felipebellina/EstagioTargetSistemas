using EstagioRibeiraoPreto.Classes;

while (true)
{
    Console.WriteLine("""
    1 - Sequência Fibonacci
    2 - Verificar String
    3 - Questão 3
    4 - Questão 4
    5 - Questão 5
    0 - Para sair
    """);

    Console.Write("Digite a opção que deseja: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            Console.Clear();
            SequenciaFibonacci.Fibonacci();
            break;
        case 2:
            Console.Clear();
            VerificarString.VerificarTexto();
            break;
        case 3:
            Console.Clear();
            QuestaoTres.ValorSoma();
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("""
                4) Descubra a lógica e complete o próximo elemento:
                a) 1, 3, 5, 7, (9)
                b) 2, 4, 8, 16, 32, 64, (128)
                c) 0, 1, 4, 9, 16, 25, 36, (49)
                d) 4, 16, 36, 64, (100)
                e) 1, 1, 2, 3, 5, 8, (13)
                f) 2,10, 12, 16, 17, 18, 19, (200)
                """);
            Console.WriteLine("Precione enter para seguir");
            Console.ReadKey();
            Console.Clear();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("""
                Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

                Ligue um interruptor, espere um tempo e desligue-o. Em seguida, ligue outro interruptor e vá até uma sala. Se a lâmpada estiver ligada, vá até uma sala diferente e veja se a lâmpada está quente. Se estiver quente, é a lâmpada do primeiro interruptor que foi ligado. Caso contrário, é a lâmpada do interruptor que não foi ligado.

                Se, ao ir até a lâmpada, ela estiver desligada, verifique se está quente. Se estiver quente, é a lâmpada do primeiro interruptor. Caso contrário, é a lâmpada do interruptor que não foi ligado. Em seguida, vá até outra sala e verifique se a lâmpada está ligada ou desligada. Se estiver desligada, verifique se está fria ou quente.

                """);

            Console.WriteLine("Precione enter para seguir");
            Console.ReadKey();
            Console.Clear();
            break;
}
}



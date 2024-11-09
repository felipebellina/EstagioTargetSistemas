namespace EstagioRibeiraoPreto.Classes;

public class QuestaoTres
{
    // Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);

    public static void ValorSoma()
    {
        int indice = 12;
        double soma = 0;
        int k = 1;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        Console.WriteLine($"O valor da variável SOMA é: {soma}.\n");

        Console.WriteLine("Precione enter para seguir");
        Console.ReadKey();
        Console.Clear();
    }
}

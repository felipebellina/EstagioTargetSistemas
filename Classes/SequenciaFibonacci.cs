namespace EstagioRibeiraoPreto.Classes;

public class SequenciaFibonacci
{

    public static void Fibonacci()
    {
        Console.Write("Digite o número que deseja verificar se está na sequência fibonacci: ");

        int numeroUsuario = int.Parse(Console.ReadLine());
        int anterior = 0;
        int atual = 1;
        List<int> sequenciaFibonacci = new List<int>();

        for (int i = 0; anterior < numeroUsuario; i++)
        {
            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
            sequenciaFibonacci.Add(anterior);
            if (numeroUsuario == anterior)
            {
                Console.WriteLine($"O número {numeroUsuario} faz parte da sequência fibonacci");
            }
        }

        if (anterior > numeroUsuario)
        {
            Console.WriteLine($"O número {numeroUsuario} não faz parte da sequência fibonacci");
        }

        Console.WriteLine("Precione enter para seguir");
        Console.ReadKey();
        Console.Clear();
    }

}

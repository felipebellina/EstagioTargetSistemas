namespace EstagioRibeiraoPreto.Classes;

public class VerificarString
{
    public static void VerificarTexto()
    { 
        Console.WriteLine("Digite o texto que deseja verificar quantas vezes a letra a se repete:");
        string textoUsuario = Console.ReadLine();
        string textoLowerCase = textoUsuario.ToLower();
        bool response = textoLowerCase.Contains('a', StringComparison.OrdinalIgnoreCase);
        
        if (string.IsNullOrEmpty(textoLowerCase) || response == false)
        {
            Console.WriteLine("O texto não possui a letra [a]");
        }
        else 
        {
            int contador = textoLowerCase.Count(t => t == 'a');
            Console.WriteLine($"No texto \"{textoUsuario}\" a letra [a] se repete {contador} vezes.");
        }

        Console.WriteLine("Precione enter para seguir");
        Console.ReadKey();
        Console.Clear();
    }
}

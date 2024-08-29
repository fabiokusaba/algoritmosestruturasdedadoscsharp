namespace EstruturaDeDados.Arrays;

public static class Utils
{
    // Esse método Imprime é uma extensão que eu criei para os arrays, então todos os arrays vão ter esse método aqui
    public static void Imprime<T>(this T[] array, string mensagem)
    {
        Console.WriteLine(mensagem);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
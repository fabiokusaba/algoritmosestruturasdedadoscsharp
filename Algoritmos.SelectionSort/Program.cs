// Selection Sort -> a primeira coisa que vocês percebem aqui é esse for mais externo que vai percorrer todos os elementos
// do array, lembrando que as estruturas de dados que trabalhamos aqui começam do índice 0, e começamos a ver coisas que as
// vezes podem passar batido indiceDoMenor eu preciso de um lugar pra guardar esse índice, é o índice do menor valor que eu
// encontrei, e aí eu procuro o menor no restante do array quando ele perceber que o que ele está olhando é menor do que o
// menor que ele tem guardado ele troca, chegando ao final depois de ter percorrido o restante do array ele vai trocar o valor
// encontrado com o valor na posição atual, e aqui é uma outra situação de pensamento algorítmico que precisamos ter em que
// vamos precisar de uma variável temporária para guardar o valor do menor, vamos pegar a posição do índice do menor e colocar
// nele o valor que está no array na posição i, no final estamos trocando o valor de posições, no final pegamos o array na posição
// i que estamos olhando e colocamos nele o valor da nossa variável temporária, ao final incrementamos o i e fazemos tudo de novo

int[] teste = new int[]{7, 2, 1, 3, 4, 8, 9};
SelectionSort(teste);
Console.WriteLine();

static void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        // Assume que o menor valor está na posição atual
        int indiceDoMenor = i;

        // Procura o menor no restante do array
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[indiceDoMenor])
            {
                indiceDoMenor = j;
            }
        }

        // Troque o valor encontrado com o valor na posição atual
        int temp = arr[indiceDoMenor];
        arr[indiceDoMenor] = arr[i];
        arr[i] = temp;
    }
}
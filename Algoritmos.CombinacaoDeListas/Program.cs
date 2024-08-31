// Listas - combinando listas: vamos trabalhar com o algoritmo de combinação de listas ordenadas, a listaCombinada vai ser o
// lugar aonde eu vou guardar a lista final, criamos duas variáveis i e j, já vemos uma diferença em relação ao algoritmo da
// ordenação lá nós utilizamos dois mas um tinha relação com o outro o j era sempre o i + 1 nesse aqui a gente já percebe que
// declaramos ao mesmo tempo então provavelmente eles tem aí uma independência, então qual é a primeira coisa que eu vi aqui
// bom, eu vou olhar se o i é menor que a quantidade de itens que eu tenho na lista1 e o j a quantidade de itens que eu tenho
// na lista2 então a gente já percebe que o i ele serve com índice pro lista1 e o j pro lista2, aí ele vai entrar vai lá na 
// lista1 e pega a posição do i, vai lá no lista2 pega a posição do j e vê os valores, verificamos se o valor que está na lista1
// é menor que o valor que está na lista2 se for menor ele vai pegar esse menor jogar na listaCombinada e incrementar o i, e vai
// repetir a comparação até chegar num momento que o valor que está na lista2 for menor que o valor que está na lista1 nesse caso
// ele vai cair no else vai jogar o valor na listaCombinada e incrementar o j, nessa hora que a minha condição do while deixar de
// ser verdadeira (true) ele vai sair do loop e seguir o código

List<int> list1 = new List<int>{1, 3, 5, 7};
List<int> list2 = new List<int>{2, 4, 6, 8, 9};

List<int> result = CombinaListasOrdenadas(list1, list2);
// Deve imprimir "1, 2, 3, 4, 5, 6, 7, 8, 9"
Console.WriteLine(string.Join(", ", result));

static List<int> CombinaListasOrdenadas(List<int> lista1, List<int> lista2)
{
    List<int> listaCombinada = new List<int>();
    int i = 0, j = 0;

    // Enquanto houver elementos em ambas as listas
    while (i < lista1.Count && j < lista2.Count)
    {
        if (lista1[i] < lista2[j])
        {
            listaCombinada.Add(lista1[i]);
            i++;
        }   
        else
        {
            listaCombinada.Add(lista2[j]);
            j++;
        }
    }

    // Adicione elementos restantes da list1
    while (i < lista1.Count)
    {
        listaCombinada.Add(lista1[i]);
        i++;
    }

    // Adicione elementos restantes da list2
    while (j < lista2.Count)
    {
        listaCombinada.Add(lista2[j]);
        j++;
    }

    return listaCombinada;
}
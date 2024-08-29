// Listas são basicamente os arrays vitaminados, a lista em si possui o array dentro dela, se você for olhar o
// código fonte de como é implementado ao menos no C# uma lista você vai ver que ele tem um array e dentro dessa
// lista esse array vai ser mexido por métodos que a lista implementa, então a verdade aqui é que ele está
// encapsulando pra gente um monte de coisa que a gente poderia fazer manualmente
// Pense que tudo o que você faz com arrays você pode fazer com lista e algumas coisas a mais
// Então, criamos aqui uma lista de inteiros e esse tipo de declaração é porque você tipa, a lista aqui no caso
// ela dá um passo além do array e ela já é fortemente tipada, então se eu tentar impurrar pra dentro de uma lista
// uma string ou qualquer outro tipo que não seja um inteiro o compilador vai reclamar
// E também você já consegue ver o mesmo ForEach que eu tinha lá no array eu consigo utilizar aqui, mas diferente do
// array onde eu tinha que usar a classe Array aqui não, aqui eu uso diretamente na instância da minha lista

// Uma coisa que vocês podem já de cara entender é que eu poderia simplesmente não passar os valores, eu consigo criar
// uma lista e não falar nem os elementos dela e nem quantos espaços eu vou querer nela porque ela diferentemente do
// array ela é dinâmica, eu posso simplesmente criar uma lista vazia sem nenhum item e logo em seguida colocar mais um
// item, colocar mais outro item, colocar n itens que eu quiser, então a lista você pode incluir e excluir, inclusive
// eu posso remover, eu posso aumentar ou diminuir o tamanho dela dinâmicamente
// Eu posso tanto incluir mais um item como eu fiz utilizando o método Add, como eu posso utilizar o AddRange e colocar
// um intervalo de itens, um conjunto de itens
// Outra facilidade que a lista me dá é que eu posso também dar um Insert, posso dar também um InsertRange, então eu tenho
// Add e AddRange, Insert e InsertRange, a diferença do Insert para o Add é que no Insert eu indico a posição que eu quero
// inserir aquele conjunto ou no nosso caso somente esse outro item
// E por último aqui também o Sort que como nós já vimos no array vai ordenar o que a gente quiser, a diferença aqui é que
// nós temos mais alguns tipos de Sort no qual a gente pode passar um comparador

var numeros = new List<int>(){8, 5, 1, 3};

Console.WriteLine("Imprime list");
numeros.ForEach((item) => Console.WriteLine(item));

var outrosNumeros = new List<int>();

outrosNumeros.Add(2);
outrosNumeros.Add(4);

numeros.AddRange(outrosNumeros);
Console.WriteLine("Imprime list (addrange)");
numeros.ForEach((item) => Console.WriteLine(item));

numeros.Insert(1, 99);
Console.WriteLine("Imprime list (insert)");
numeros.ForEach((item) => Console.WriteLine(item));

numeros.Sort();
Console.WriteLine("Imprime list (sort)");
numeros.ForEach((item) => Console.WriteLine(item));

// "LINQ"
// Criando um array utilizando a lista
var meuArray = numeros.ToArray();

// Poderia fazer o inverso também, transformar um array em lista
var minhaLista = meuArray.ToList();
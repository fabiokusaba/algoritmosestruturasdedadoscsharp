// Arrays ou matrizes talvez seja a forma, a estrutura de dados mais conhecida que você vai achar em qualquer linguagem
// de programação, essa é uma estrutura que representa uma coleção de objetos do mesmo tipo
// Quer dizer que é um lugar onde eu vou juntar coisas semelhantes, coisas iguais, ou seja, eu posso ter um grupo de
// inteiros, posso ter um grupo de strings, posso ter um grupo de alguma classe que eu criei, posso ter objetos e aí no
// caso de objeto eu posso colocar qualquer coisa ali dentro
// A forma como os arrays são estruturados dentro de memória, como eles são guardados pensa que o compilador quando você
// cria um array ele vai pegar uma faixa contínua da memória
// No C# declaramos o array dessa forma: colocamos o tipo que a gente quer, os colchetes, o nome, e posso já criar os
// elementos aqui. Existem várias formas, eu posso simplesmente criar um array e declarar quantas posições eu quero e
// depois eu coloco os elementos
// Se a gente quiser fazer referência a algum item desse array é dessa forma que a gente faz: colocamos o nome do array
// entre colchetes colocamos o índice e o que a gente quer colocar lá dentro. Da mesma forma, se eu quiser consultar um
// item eu também utilizo o mesmo padrão
// Se eu quisesse imprimir cada item de um array o jeito mais comum é eu fazer um foreach, passar no array, pegar cada
// item dele e imprimir

// 

int[] numeros = { 0, 1, 2, 3, 4, 5 };
numeros[0] = 10;

Console.WriteLine($"Item 3: {numeros[3]}");

foreach (var item in numeros)
{
    Console.WriteLine(item);
}
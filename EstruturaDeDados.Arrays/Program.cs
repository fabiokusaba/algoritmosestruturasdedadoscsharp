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

// A gente precisa entender o seguinte conceito: um array é um espaço limitado e imutável na memória, o que eu quero
// dizer é que quando separou-se para nós 6 espaços na memória, esses espaços foram separados e os espaços antes como
// os espaços depois podem estar sendo utilizados daí que se você perceber que o tamanho do seu array não foi suficiente
// o compilador/computador ele não pode simplesmente reservar um pedaço logo após ou um pedaço logo antes pra utilizar
// porque ele não tem acesso, por questões de segurança o seu programa não pode ter acesso a outras partes da memória
// dessa forma cada array criado tem somente aquele espaço pra ele mesmo que você não utilize, então toda vez que você
// precisar alterar o tamanho do seu array você vai precisar criar um novo
// Utilizando o método Copy do Array, então temos uma classe para arrays aqui no C# como temos em outras linguagens, no
// C# o que a gente faz? A gente pede para o Array, que seria uma instância superior, uma classe mãe de todos os arrays
// pra ela fazer uma cópia entre os arrays e aí eu passo o primeiro e o segundo e digo o tamanho porque eu não preciso
// copiar tudo eu poderia copiar somente uma parte, nesse caso estamos copiando o array numeros que tem 5 itens e estou
// copiando tudo só que como eu não tinha o tamanho suficiente para completá-lo, não tem problema ele fica com o valor
// padrão
// Quando nós criamos um array dessa forma aqui dizendo só o tamanho dele o compilador vai criar pra gente um array com
// o valor padrão do tipo que a gente está informando, se eu falei que eu quero um array de inteiros o valor padrão de
// um inteiro é 0, então ele vai preencher todos com 0, se fosse um objeto seria nulo, se fosse uma string seria nulo
// Essa operação de você criar e copiar é oneroso, cai o desempenho do sistema
// A parte positiva do array e a sua principal força é que ele é muito rápido como você trabalha numa questão de index
// de índice você sempre sabe onde buscar e como o espaço na memória ele é contínuo ele sempre vai saber, o compilador
// sempre vai saber achar muito rápido essa informação 

// Sempre que precisarmos pegar o tamanho do array podemos utilizar o Length
// Na última aula vimos como aumentar o tamanho de um array a gente cria um novo array copia as coisas pra lá, mas a 
// gente tem uma forma automatizada de fazer isso o Array, aquela classe que seria a mãe de todos os arrays, ela tem
// uma função chamada Resize, alterar o tamanho, no qual ela recebe o seu array e a gente tem que colocar ref que aqui
// no C# é pra gente poder realmente alterar aquela coisa que a gente passou porque de outra forma o array aqui é um
// tipo de referência se eu mando ele dessa forma lá dentro depois que ele fizesse tudo o que ele tem que fazer ele
// descartaria, o ref faz eu alterar a minha variável inicial que é o números, então eu vou estar realmente mexendo aqui
// no números, e o que eu faço? Passo o que eu quero alterar, ou seja, o array que eu quero alterar, no caso eu quero
// aumentar de tamanho ou diminuir e o novo tamanho. Mas, aqui continua com os mesmos problemas de performance que
// comentamos na aula passada, não é para ser usado indiscriminadamente com arrays muito grandes
// O IndexOf é uma forma de você buscar dentro do array por um determinado valor, isso daqui também não é pra ser 
// utilizado a torto e a direito, não é a função do array, a gente não utiliza o array pra gente colocar coisas que a
// gente vai ficar procurando depois, mas o que ele faz aqui? Ele busca, é também da classe mãe Array, nesse método a 
// gente passa o array no qual a gente vai fazer a busca e o valor que a gente vai buscar
// Nós temos o Sort que vai arrumar o array, vai ordenar o nosso array, lógico que nesse caso o tipo do array importa
// porque precisa ser um array de um tipo que o compilador saiba ordenar IComparable, ele precisa saber como uma coisa
// é maior que a outra e com números isso é meio óbvio basta olhar o número
// E por último a parte do Reverse em que ele vai inverter a ordem do seu array, o que eu quero chamar atenção aqui é
// que o Reverse não é que ele ordena ao contrário, ele pega o seu array do jeito que está e inverte, ele inverte o que?
// Ele inverte a última posição com a primeira, a penúltima com a segunda e assim por diante
// E por último e não menos importante o ForEach que pega cada item do array e para cada iteração ele vai fazer alguma
// coisa, no nosso caso a gente passa o nosso array e passo uma função para qual cada item vai ser enviado, aqui nós
// poderíamos simplificar com a utilização de lambdas porque o que o ForEach vai estar pedindo? Ele vai estar pedindo um
// array e algo pra fazer, que no nosso caso foi o método imprime

using EstruturaDeDados.Arrays;

int[] numeros = { 8, 4, 3, 0, 1, 9, 7, 6 };
numeros.Imprime("Array inicial");

Console.WriteLine($"Tamanho: {numeros.Length}");

Array.Resize(ref numeros, 20);
Console.WriteLine($"Novo tamanho: {numeros.Length}");

Console.WriteLine($"IndexOf: {Array.IndexOf(numeros, 0)}");

Array.Sort(numeros);
numeros.Imprime("Array ordenado");

Array.Reverse(numeros);
numeros.Imprime("Array invertido");

Console.WriteLine("ForEach");
// Array.ForEach(numeros, imprime);
Array.ForEach(numeros, (x) => Console.WriteLine(x));

// void imprime(int x)
// {
//     Console.WriteLine(x);
// }

// int[] numeros = { 0, 1, 2, 3, 4, 5 };
// numeros[0] = 10;
//
// Console.WriteLine($"Item 3: {numeros[3]}"); // 3
//
// numeros = new int[] { 1, 2, 3, 4, 5 };
// Console.WriteLine($"Item 3: {numeros[3]}"); // 4
//
// int[] numeros2 = new int[10];
// Array.Copy(numeros, numeros2, 5);
//
// foreach (var item in numeros2)
// {
//     Console.WriteLine(item);
// }
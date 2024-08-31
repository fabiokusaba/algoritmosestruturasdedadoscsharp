// Dicionários são formados por uma coisa, por uma unidade basicamente assim que geralmente a gente acha isso como: par
// de key e value, seria uma par chave e valor, o que quer dizer isso? Quer dizer que a gente vai ter uma informação que
// serve como chave e uma que é o valor propriamente dito que a gente quer encontrar, a gente pode fazer uma analogia com
// um dicionário mesmo que a gente usa tem uma coisa que a gente quer saber: a descrição, qual seria a chave no dicionário
// o nome da coisa
// O dicionário seria uma estrutura de dados que tem uma coleção com todas essas chaves e valores, então não pode ter chave
// repetida porque é uma questão de individualidade, dessa forma que o código lá dentro, o compilador vai saber organizar e
// vai deixar esse dicionário muito rápido de você encontrar, ele não é exatamente ordenado então se a gente utilizar como
// exemplo nomes: Milton, Suzana, Antônio, ele vai colocando lá dentro, ele não ordena, mas por trás do dicionário tem um
// negócio que a gente chama de HashTable que também é uma estrutura de dados e uma de suas implementações também é o dicionário
// no caso do C# que tomamos como base aqui a diferença do dicionário para o HashTable é que o HashTable ele trabalha só com
// objetos, ele não trabalha com generics, ou seja, não posso criar uma HashTable de um tipo Aluno eu só consigo colocar como
// objeto e aí quando eu enfiar esse Aluno como objeto tem a questão de boxing/unboxing que gasta muito processamento do
// computador, então eles enfiaram a HashTable aqui dentro do dicionário e a gente utiliza ela nessa questão de organizar os
// dados para ficar mais rápido de achar, e o que é a HashTable? A HashTable é uma tabela com hashes e o que é o hash? O hash
// é o seguinte: quando eu passo essa informação Milton e digo que a minha chave é Milton existe uma função que você vai jogar
// o Milton lá dentro e vai sair, por exemplo um número, então eu sei que o Milton depois de eu fazer algum determinado cálculo que 
// a minha função de hash ele me deu o número 23478, aí quando eu joguei a Suzana o número que me deu foi 12465, e o Antônio saiu
// um 32476, e aí vai ter um lugar dentro do dicionário onde o dicionário vai colocar cada um desses hashes que ele achou aqui, então
// ele sabe que a Suzana vai ser a primeira 12465, e aqui sim ele vai organizar, e o próximo vai ser o Milton 23478 e o próximo o
// Antônio 32476, mas ele deixou espaço através das funções de hash ele sabe que deve deixar espaços aqui porque pode ter gente antes
// pode ter gente depois, e aí toda vez que você procurar pela Suzana esse nome vai passar por uma função de hash que vai achar o mesmo
// valor e aí ele sabe que a Suzana que estamos procurando é o 12465 e vai trazer a informação, por isso que é muito rápido, é como se
// ele criasse um índice dentro dessa tabela de hash com todos que estão lá

Dictionary<string, int> meuDicionario = new Dictionary<string, int>();

meuDicionario.Add("chave1", 1);
meuDicionario.Add("chave2", 2);
meuDicionario.Add("chave3", 3);
meuDicionario.Add("chave4", 1);

int count = meuDicionario.Count;

int value;
// Acessando uma chave inexistente dessa forma direta vai dar erro, se existisse daria certo mas não é o tipo de coisa que a gente
// vai fazer
// value = meuDicionario["chave11"];

// Nós utilizamos o TryGetValue para evitar uma exceção, esse método simplesmente vai te dar um true ou false, então se existir a
// chave ele vai dar um true e ainda aqui no out ele vai colocar o valor que ele achou
if (meuDicionario.TryGetValue("chave1", out value))
{
    Console.WriteLine("Valor encontrado: " + value);
}
else
{
    Console.WriteLine("Chave não encontrada.");
}

// Aqui estamos tentando adicionar um valor e novamente ele vai dar um true ou false, se ele conseguir adicionar ele dá um true, se
// ele não conseguir ele dá um false
if (meuDicionario.TryAdd("chave1", 1))  
{
    Console.WriteLine("Valor adicionado com sucesso.");
}
else
{
    Console.WriteLine("A chave já existe no dicionário.");
}

// O ContainsKey vai pegar essa "chave1" e vai olhar lá naquela tabela de hash se tem ou não tem, aqui ele simplesmente verifica se tem
// ele não vai trazer o valor ele só vai olhar
if (meuDicionario.ContainsKey("chave1"))
{
    Console.WriteLine("Chave encontrada.");
}
else
{
    Console.WriteLine("Chave não encontrada.");
}

// O ContainsValue é um uso com moderação de preferência não use, tudo o que vimos até agora era O(1), ou seja, se eu preciso adicionar
// ele é O(1) porque é muito rápido é meio que constante ele vai olhar lá na tabela dele se já tem aquela chave e inclui, TryGet também
// ele vai olhar tudo naquela tabela de hash então tudo é muito rápido, mas o ContainsValue não porque o ContainsValue ele não está
// naquela tabela de hash porque o que tem lá é uma tabela de hash com as chaves e não com os valores, o que o dicionário precisa fazer
// quando você fala verifica aí se contém o valor que eu quero? Ele vai item por item abrindo a chave até encontrar, então esse sim é
// considerado O(n) porque a medida que você vai crescendo ele vai crescendo
if (meuDicionario.ContainsValue(1))
{
    Console.WriteLine("Valor encontrado.");
}
else
{
    Console.WriteLine("Valor não encontrado.");
}

meuDicionario.Remove("chave1");

meuDicionario.Clear();
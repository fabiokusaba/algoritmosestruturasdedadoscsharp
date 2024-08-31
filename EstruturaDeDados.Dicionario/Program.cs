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
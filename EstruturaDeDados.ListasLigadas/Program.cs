// LinkedList ou lista ligada ela é composto do que a gente chama de nó, imagina que cada item da lista vai ser um nó
// Aprendemos que um array pega um espaço contínuo na memória, a lista que também já aprendemos funciona de forma semelhante
// ela também utiliza um array dentro dela só que ela tem métodos pra facilitar isso, imagine que eu tenha uma lista com 8
// posições e eu precise de mais um, então ela já sabe que vai ter que pegar aqui e criar uma outra lista com o dobro do
// tamanho, vai copiar as informações, e também separou um espaço para que a gente possa utilizar e aí se você incluiu um
// item a mais ele escreve nesse espaço e aí existe um problema de performance, por que? Porque se você tem uma lista muito
// grande consequentemente quando ele dobrar ele vai ficar ainda maior e temos o problema que ele ainda manteve na memória
// a cópia antiga, que vai ser limpa em algum momento, mas nesse momento ela ainda está lá, ainda tem a questão que ele além
// de reservar o espaço aqui em dobro ele vai ter que copiar, então ele vai um a um copiando cada elemento, isso falamos que
// é um O(n) e o que isso quer dizer? Que para cada item daquela lista ele vai ter que fazer uma cópia, ele vai ter que fazer
// alguma execução, no caso uma cópia
// Qual é a questão da lista ligada aqui? Ela não precisa fazer isso que acabamos de falar, quando a minha lista normal ela
// dobrou de tamanho porque precisava colocar um item a mais ela gastou muito processamento, ela deu uma queda de desempenho
// ela precisou fazer cópias e a lista ligada não precisa disso, a lista ligada ela funciona item por item
// A lista ligada e o nome dela é justamente por causa disso, cada item faz uma referência ao outro item e aí você pode crescer
// do jeito que você quiser e este crescimento diferente da outra lista ele é O(1) que quer dizer que eu só gasto uma unidade
// de processamento
// Cada item que a gente chamou de nó a gente pode representar da seguinte forma: a gente pode dizer que temos um conteúdo e a
// referência, lembra que falamos que cada item faz referência a um outro item e por isso que ele é ligado, então aqui no
// conteúdo eu posso colocar qualquer coisa 
// Lembrando que cada nó pode estar solto na memória ele não precisa estar na memória continuamente como era o array, como era a
// lista, e diferente da lista ele pode crescer sem um grande gasto
// Trade-off: enquanto que a lista ela é muito demorada para inserção e retirada porque quando a gente retira da lista a gente
// tira aquele espaço e diminui toda a lista, ou seja, a gente tem que novamente achar outro espaço na memória que caiba tudo
// aquilo, coloca tudo lá, faz uma cópia só que com um espaço a menos, isso gasta muito processamento. A lista ligada é muito
// simples imagina que eu queira apagar um item da lista eu posso simplesmente apagar as ligações e religar e automaticamente o
// elemento ficou morto e quando passar o garbage collector ele fará a limpeza porque ninguém mais precisa disso, então temos o
// ganho aqui
// Retomando, qual é a diferença principal entre a lista ligada e a lista? Se você trabalhar muito com inclusão e exclusão a lista
// ligada é melhor, ela é mais perfomática, você pode incluir e excluir rapidamente a sua complexidade é O(1). O grande problema da
// lista ligada é quando você precisa ler, se você precisa ler, se você precisar acessar uma posição ele não trabalha com índice e
// como ele trabalha? Ele trabalha analisando item por item, a sua pesquisa é O(n), é uma pesquisa onerosa, então se você precisa de
// busca, de leitura a lista ligada já não é tão legal, melhor seria uma lista, um array
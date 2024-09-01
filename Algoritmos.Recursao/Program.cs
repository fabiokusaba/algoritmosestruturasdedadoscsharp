// Recursão - é muito associado aquelas bonequinhas russas matrioscas que você vai abrindo e tem uma boneca dentro de
// outra boneca e assim sucessivamente
// Imagine que você tem que fazer uma função no qual você vai receber como parâmetro uma caixa e vai ter que dizer o que
// tem dentro dessa caixa só que aí quando você abre essa caixa você vê que tem outra caixa e dentro dessa caixa você
// percebe que tem outra caixa e poderíamos seguir isso infinitamente só que o que você quer na sua função não é dizer
// que uma caixa tem outra caixa é achar o conteúdo da última caixa, ou seja, que não tem uma caixa dentro e aí você diz
// o conteúdo
// A primeira coisa que eu faço ao escrever um algoritmo recursivo é colocar o caso base porque ele que vai retornar pra
// mim o valor quando não precisar mais da recursão, o que isso quer dizer? No nosso exemplo vamos ter várias caixas uma
// dentro da outra se eu abrir uma dessas caixas e ela não tiver uma caixa dentro acabou a recursão eu não preciso mais
// ficar abrindo caixa porque eu já cheguei ali na última caixa, no meu caso base
// Mas, se eu abrir uma caixa e encontrar uma caixa dentro dela estou no caso recursivo isso quer dizer que se eu peguei
// uma caixa abri e tem uma caixa dentro eu pego essa caixa de dentro/interna mando para esse algoritmo e vejo o retorno
// que me dá, então o algoritmo vai ficar funcionando como se fosse um loop ele vai ficar chamando a ele mesmo até que a
// condição base seja resolvida, seja atingida
// Se nós olharmos a stack, a stack seria como o que está acontecendo naquele momento ele vai colocando uma função em
// cima da outra e depois ele vem resolvendo, nós estávamos no main que era o principal lá onde o nosso programa começa
// chamamoss o Executar do AlgoritmoRecursao, veja que aqui estamos trabalhando com uma stack, uma pilha em que vou
// empilhando, dali chamei um Fatorial e dentro desse Fatorial eu chamei o Fatorial denovo, enquanto eu ficar chamando
// esse Fatorial ele vai empilhando, ao atingir o nosso caso base ele vai resolver aquela chamada retornando o valor e
// sumindo da stack, agora vamos voltar aquela outra chamada para ir resolvendo os casos com o valor obtido, finalizado
// todas as chamadas da função Fatorial ele simplesmente vai imprimir o resultado

using Algoritmos.Recursao;

AlgoritmoRecursao.Executar();
// Strings ou cadeia de caracteres como a gente pode traduzir tem esse nome exatamente porque pode ser levada de forma
// literal, uma cadeia de caracteres que tem vários caracteres postos um junto dos outros, então toda vez que você pensar
// numa string pense num array, a diferença é que na string só vai aceitar caracteres
// A string como o array é imutável, então se eu tiver a minha string "pipoca" e preciso criar "pipocas" se eu for alterar
// se eu tentar alterar, se eu falar assim a variável "pipoca" agora é igual a "pipocas" o compilador não vai chegar pra mim
// criar um espaço na memória e colocar o "s" aqui, ele não tem como fazer isso, ele não tem como garantir que o próximo
// espaço vai estar livre, lembra a memória no nosso computador ela está compartilhada mesmo o espaço de memória reservado
// para o nosso programa ele vai estar utilizando outras coisas do nosso próprio programa, quando a gente cria um programa
// em .NET é reservado um espacinho ali na memória pra gente, esse espacinho que eu usei para criar a variável "pipoca" no
// outro pedaço pode estar usando outra coisa, pode estar com outra variável ou qualquer outra coisa, tanto atrás quanto na
// frente
// Então, a partir do momento que eu tenho essa string "pipoca" se eu quiser criar uma chamada "pipocas" o que o compilador
// vai fazer é o seguinte: ele vai achar outro lugar na memória onde caiba o que a gente precisa, então ele vai criar um espaço
// suficiente para caber "pipocas" e essa string "pipoca" vai perder a referência e será apagada quando o coletor de lixo ou
// garbage collector passar e ver que ninguém está usando ela, mas antes dele fazer isso as duas strings vão estar na memória
// vão estar gastando memória o que pode deixar o meu programa ficar lento e isso acontece a qualquer momento que você altere
// uma string
// Toda a forma de trabalhar com string sempre tem que ser bem pensada, no C# a gente tem uma coisa chamada StringBuilder que
// é otimizado e aí sim ele trabalha melhor essa questão de lidar com a memória, e um truque muito bom que vocês vão ver quando
// a gente tiver mexendo com algoritmos é que a gente pode simplesmente, como falei toda string é um array de caracteres, a gente
// pode utilizar os métodos que nós já estamos acostumados a utilizar no array na string e eles vão funcionar
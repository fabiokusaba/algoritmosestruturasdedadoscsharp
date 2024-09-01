// Ordenação por inserção - não é algo que você vai colocar no seu código de verdade porque não é um código eficiente,
// mas ele se torna a base para entendermos os próximos algoritmos, imagine cartas de um baralho temos 5, 3, 4, 6 e 2
// ou seja, elas não estão em ordem se a gente fosse colocar isso em ordem o movimento mais comum é pegar a carta 2 e
// colocar no local correto no nosso algoritmo nós vamos fazer diferente a gente vai separar as cartas em dois grupos
// imagine que a carta 5 pertence a um grupo e todas as demais cartas pertencem a outro grupo então temos um grupo do
// que já está ordenado e o outro não está e por que esse grupo já está ordenado? Porque veja é um grupo de uma carta só
// se só tem uma carta ela vai estar em ordem, ou seja, ela vai ser a menor desse grupo por ser única, agora o que a 
// gente vai fazer é pegar uma carta do outro grupo para colocar em ordem nesse grupo ordenado, no caso vamos pensar que
// pegamos a carta 3 e vamos comparar com a carta 5 ele é menor ou maior? Menor, então eu já coloco ele aqui e a partir
// desse momento esse grupo está em ordem, parto para a próxima carta que é o 4 e comparo nesse grupo e é sempre isso
// vou tirando do grupo de desordenados para colocar nesse grupo de ordenados
// Outra coisa importante aqui é que na nossa linguagem C# e na maioria das linguagens de programação o índice começa
// com zero

// Array nada mais é do que um conjunto, aqui eu tenho um conjunto de inteiros
int[] teste = { 5, 3, 4, 6, 2 };

// Transformo esse array numa lista pra poder usar ele no string.Join, o string.Join vai pegar cada item da lista
// coloca algum caracter no meio, no caso a vírgula e um espaço, me retorna isso como string e faço a impressão no
// console
Console.WriteLine(string.Join(", ", teste.ToList()));

OrdenacaoPorInsercaoInt(teste);

Console.WriteLine(string.Join(", ", teste.ToList()));

void OrdenacaoPorInsercaoInt(int[] array)
{
    // A gente já começa do 1 porque lembra aquilo que a gente fez com as cartas a gente separou essa primeira como se
    // já fosse um grupo ordenado, então essa daqui é o 0, então eu já começo ordenando a 1 porque a 0 já está no lugar
    // porque se fosse um grupo de uma carta ela já estaria ordenada por isso vou começar olhando essa carta aqui de 
    // índice 1
    // Esse loop vai rodar até o i ser do tamanho do array, ou seja, até chegar na última carta enquanto não chegar na
    // última carta ele não para e vai incrementando de 1 em 1
    for (int i = 1; i < array.Length; i++)
    {
        // Cria uma variável j e coloca esse valor do i nela, aqui a gente entende porque temos que guardar a posição i
        // no j porque na hora que a gente está fazendo essa verificação a gente precisa saber em qual posição a gente
        // está verificando, se eu não utilizasse essa variável eu iria me perder na verificação
        int j = i;

        // Então, eu sei que nesse momento eu estou na carta 1, que das 5 cartas é a segunda porque lembra o índice
        // começa em 0
        // Primeiro lugar eu olho se o j é maior que 0, se for e veja que esse é um && com curto-circuito que quer dizer
        // se isso daqui for falso j > 0 eu nem olho o resto eu simplesmente pulo, se for verdadeiro aí eu dou uma 
        // olhada para o lado pra ver se ele continua verdadeiro, ou seja, os dois lados precisam ser verdadeiros para
        // que ele faça o que está logo abaixo
        // E o que ele vai olhar aqui? Ele vai olhar se a carta na posição j é menor que a carta da posição anterior
        while (j > 0 && array[j] < array[j - 1])
        {
            // Aqui a gente tem esse temp e é aquilo que falei no início sobre pensamento computacional então eu preciso
            // guardar a informação em algum lugar temporário pra poder realizar a troca de posições
            int temp = array[j];
            
            // Aqui ele está dizendo que a carta que está na posição j é igual a carta da posição anterior, ou seja, ele
            // pega o que está na posição 1 e dá pra ele o valor da carta anterior assim ele sobrescreveu o valor
            array[j] = array[j - 1];
            
            // Agora nessa linha eu falo coloca na posição anterior o valor que está em temp
            array[j - 1] = temp;
            
            // E aí eu diminuo o j e por que isso? Primeiro porque eu estava olhando a posição 1 só que agora eu já
            // arrumei essa posição, se eu olhar essa posição novamente vou estar fazendo um trabalho perdido porque eu
            // já ordenei esse pedaço, então eu diminuo o meu j e aí a gente entende porque tem esse j > 0, eu estava
            // no j como sendo 1 e agora terminei no j como sendo 0, se o j é 0 não tem mais carta desse lado para eu
            // ordenar o 0 já é o primeiro aí ele vai pular isso e ele volta lá para o início do loop
            j--;
        }
    }
}
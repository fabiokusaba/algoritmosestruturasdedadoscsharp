// Árvores composta por nós, o nó que dá origem a todos os demais nós chamamos de nó raiz ou root, os ramos seria qualquer nó
// que tem outros nós ligados a ele, já as folhas são os nós que não tem outro nó ligado a ele, ligado no sentido de estar abaixo
// dele
// A gente sempre pode pensar em cada pedaço da nossa árvore como uma sub-árvore porque em algum momento a gente pode trabalhar com
// recursão e aí as nomenclaturas seriam reordenadas
// Nós iremos focar na árvore binária e nesse modelo de árvore a gente tem no máximo dois itens ligados a cada nó
// O nó a gente pode pensar como algo dessa forma aqui, lembrando que estou me referindo aqui de uma árvore binária, ou seja, ele tem
// no máximo dois outros nós ligados a ele, aqui eu colocaria o valor que eu quero, aqui eu teria um left e right que seria esquerda e
// direita que simplesmente é pra dizer o que eu vou colocar no lado esquerdo e o que eu vou colocar no lado direito

var arvore = new ArvoreBinaria();
arvore.Inserir(20);
arvore.Inserir(10);
arvore.Inserir(30);
arvore.Inserir(5);
arvore.Inserir(15);

Console.WriteLine();

// Uma árvore como falei pra vocês ela é feita de nós, seria a unidade mínima de uma árvore poderia inclusive considerar um nó uma 
// árvore que seria uma árvore de um nó só
class ArvoreBinaria
{
    // Criei a classe nó e deixei ela como privada porque eu não quero que ela seja instânciada por fora da minha classe ArvoreBinaria
    private class No
    {
        // Falei que o nó é algo que possui um valor, aquilo que ele representa, e ele tem um link com o nó esquerdo e o nó direito
        internal int _valor;
        internal No _noEsquerdo;
        internal No _noDireito;

        // Aqui eu tenho um construtor aonde eu passo um valor
        public No(int valor)
        {
            _valor = valor;
        }

        // Sobrescrevo o método ToString para facilitar a nossa visualização
        public override string ToString()
        {
            return $"Nó={_valor}";
        }
    }

    // Ainda estou dentro da classe ArvoreBinaria e estou criando o nó que chamei de raiz, assim que eu crio uma árvore eu preciso de
    // ao menos um nó, lembra que eu falei que um nó pode ser uma árvore, então eu instânciei a nossa árvore eu já vou ter lá um nó raiz
    // Esse nó vai estar nulo, ele não vai ter valor, ele não vai ter referência a esquerda e direita, mas ele vai estar lá para eu
    // utilizar
    private No raiz;

    // E o principal aqui da nossa classe ArvoreBinaria é este Inserir, veja que é um método público, então é ele quem eu chamo lá de fora
    // passando o valor que eu quero criar, eu crio uma árvore e coloco insere um valor aí, e esse código vai ter a inteligência de falar
    // aonde esse valor deverá ser inserido
    public void Inserir(int valor)
    {
        // Assim que eu recebo o valor eu já crio um novo nó, pensa na minha árvore ela ainda não tem esse nó, esse nó estou criando na
        // memória pra ver o que faço com ele e digo que esse novo nó é o nó com o valor recebido
        var novoNo = new No(valor);

        // Se a minha raiz for nula, ou seja, se eu acabei de criar a árvore e eu não coloquei nada lá eu já sei aonde por esse valor
        // ele vai ser a raiz, isso só vai acontecer na primeira vez
        if (raiz == null)
        {
            raiz = novoNo;
            return;
        }

        // Nas vezes seguintes eu utilizo isso daqui: este noAtual ele serve como um ponteiro pra eu saber em que local que eu estou
        // verificando
        var noAtual = raiz;

        // Ou seja, é um loop infinito, enquanto true for true ele vai ficar rodando aqui, mas nós temos os nossos pontos de fuga aqui
        // dentro
        while (true)
        {
            // Se o valor que eu recebi for menor do que o valor do meu noAtual eu vou olhar para o lado esquerdo, se for maior eu vou
            // olhar para o lado direito
            // Então, eu já sei que o valor que estou mandando pra minha árvore ele é menor que o valor do noAtual que está lá, se ele
            // é menor ele vai para o lado esquerdo
            if (valor < noAtual._valor)
            {
                if (noAtual._noEsquerdo == null)
                {
                    // Então, eu vou olhar o meu lado esquerdo, se o meu nó esquerdo do meu noAtual for nulo, ou seja, não tem nada no lado
                    // esquerdo, então eu posso colocar lá
                    noAtual._noEsquerdo = novoNo;
                    break;
                }
                else
                {
                    // Já se ele não for nulo, ou seja, se no meu lado esquerdo já tem alguém lá, eu preciso comparar e aí o que eu vou
                    // fazer? Eu não saiu simplesmente comparando, eu falo que o meu noAtual agora é, lembra que no começo era o raiz, eu
                    // peguei o raiz pra olhar eu não estou mais olhando o raiz eu estou olhando o que está a esquerda dele, então agora
                    // esse que está a esquerda do raiz vai ser o noAtual para o qual estou olhando pra saber ainda se eu posso por lá ou
                    // não
                    noAtual = noAtual._noEsquerdo;
                }
            }
            // Então, se o valor for maior do que o valor do meu noAtual eu sei que eu tenho que olhar para o lado direito e aí eu faço
            // a mesma coisa que eu fiz com o esquerdo com o direito
            else if (valor > noAtual._valor)
            {
                // O nó direito do noAtual está nulo, então eu já sei que posso por ali
                if (noAtual._noDireito == null)
                {
                    noAtual._noDireito = novoNo;
                    break;
                }
                else
                {
                    // Agora se ele não está nulo eu falo que ele é o noAtual e eu vou começar a olhar pra ele pra ver o lado esquerdo e
                    // direito dele se eu posso por ou não
                    noAtual = noAtual._noDireito;
                }
            }
        }
    }
}
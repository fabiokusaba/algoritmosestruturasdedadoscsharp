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

// Vocês vão ver que o resultado de iguais é true, ele é verdade, o nome e o nome2 são iguais, mas quando eu olho para as referências
// deu true muito especificamente quando a gente cria strings que a gente chama assim de forma literal, a gente escreveu aqui no código
// o que a string é, no nosso caso "João", quando isso acontece o compilador tem inteligência de saber que isso aqui é a mesma coisa
// usa o mesmo espaço na memória, então tanto nome quanto nome2 apontam para o mesmo lugar na memória por isso que o ReferenceEquals
// aqui mostra que está igual, o ReferenceEquals verifica realmente a referência, o ponteiro se é a mesma coisa e não o conteúdo, então
// nesse momento muito específico a gente tem duas variáveis apontando pro mesmo lugar teria aí uma certa economia na memória, mas só
// vale quando é exatamente a mesma coisa e quando está escrito
// Perceba que nomeCompleto e nomeCompleto2 são iguais, os dois são "João Silva", mas agora olha o que acontece quando eu verifico se
// as referências nomeCompleto e nomeCompleto2 são iguais, lembra que o conteúdo é exatamente igual, mas quando eu comparo agora ele
// fica falso confirmando o que disse anteriormente apesar de nomeCompleto2 ser igual ao nomeCompleto ele não apontou para o mesmo lugar
// porque não está escrito aqui no código literalmente, então para facilitar a vida pensa sempre mesmo que eu esteja criando variáveis
// iguais eu estou usando espaço na memória diferente, estou sobrecarregando, nesse momento nomeCompleto e nomeCompleto2 estão ocupando
// dois espaços na memória
// E isso serve para a gente comentar algo muito especial da string que a string é um tipo por referência, então o que conta aqui são as
// referências, se você for olhar a variável nomeCompleto na verdade ela está apontando para um outro lugar, nesse outro lugar vai estar
// escrito "João Silva", a variável em si nomeCompleto ele vai guardar lá na stack, são dois espaços na memória a stack e a heap, a stack
// ela é muito mais rápida só que ela é pequena, a heap ela demora mais porque ela é maior
// Então, o que a string faz? Ela pega essa variável guarda na stack o endereço que faz referência ao lugar lá na heap

// Posso usar o IndexOf para achar qualquer string lá dentro, posso procurar uma palavra e ele vai me retornar a posição, ou posso
// procurar somente por uma letra, lembrando que vai dá a primeira aparição dessa letra, o índice onde aparece primeiro. Importante
// lembrar que começa do índice 0
// Também tem o LastIndexOf que vai olhar o último índice e aqui faz diferença se estamos buscando com letra maiúscula ou minúscula
// dá pra você pedir pra ignorar maiúsculas e minúsculas através do StringComparison ou o mais comum é você jogar tudo pra minúsculo
// ou tudo pra maiúsculo e verificar ali, como vocês podem ver aqui também tem uma questão de startIndex que mostra aonde você quer
// começar a comparar
// Com o método Replace eu consigo trocar uma palavra ou letra por outra, lembre-se que aqui ele cria uma nova frase, a frase original
// continua a mesma coisa e isso vai afetar a memória também
// O método Substring é possível pegar uma palavra da nossa frase para isso passamos aonde ele vai começar e aqui vai o detalhe que o
// índice é baseado em 0, e também o tamanho que eu não digo onde termina, eu digo o tamanho que eu quero. Se utilizarmos o mesmo
// método só com o startIndex ele pega o resto, ele começa do índice que foi passado e vai até o final
// Outros métodos úteis: texto em maiúscula ToUpper, texto em minúsculo ToLower
// Quando temos espaços em branco no final e no início se eu utilizar um Trim eu tiro esses espaços em branco, da mesma forma se eu
// desse o TrimStart removeria do início e TrimEnd removeria do final
// StartsWith começa com
// EndsWith termina com
// Contains contém algo em qualquer parte da string
// Se eu utilizar o string.Join, veja que o Join ele é um método da string não de uma string específica, é um método da string como um
// tipo em si, esse Join ele recebe um separator, ou seja, um separador e uma lista de strings, e o que ele faz? Ele passa nessa lista
// pega cada string dessa junta com esse separador aqui e coloca outra string na sequência
// E da mesma forma, se você tiver uma frase aqui e usar o Split, repara que a gente utiliza a string que a gente criou frase.Split,
// então a gente vai utilizar em cima daquela string ali, e também indicar o separator, o que ele vai fazer? Ele vai pegar cada palavra
// da frase e quebrar num array, seria o oporto do que fizemos com o Join

using System.Text;

string minhaString = "Olá, mundo!";
var outraString = "1234";

string nome = "João";

string sobrenome = "Silva";
string nomeCompleto = nome + " " + sobrenome;
string nomeCompletoInterpolado = $"{nome} {sobrenome}";

string nome2 = "João";

bool iguais = nome == nome2;
bool refIguais = ReferenceEquals(nome, nome2);

iguais = false;

string nomeCompleto2 = "João Silva";
iguais = nomeCompleto == nomeCompleto2;
refIguais = ReferenceEquals(nomeCompleto, nomeCompleto2);

nomeCompleto = "";

nomeCompleto = string.Concat(nome, " ", sobrenome);

string frase = "O rato roeu a roupa do rei de Roma";
int posicao = frase.IndexOf("roupa");
int ultimaPosicao = frase.LastIndexOf("r");

string novaFrase = frase.Replace("rato", "gato");
string outraFrase = frase.Replace('r', 'g');

string palavra = frase.Substring(2, 4);
string restoDaFrase = frase.Substring(11);

string texto = "eXeMpLo De TeXtO";
string textoMaiusculo = texto.ToUpper();
string textoMinusculo = texto.ToLower();

texto = "   exemplo de texto com espaços em branco   ";
string textoSemEspacos = texto.Trim();
string textoSemEspacosInicio = texto.TrimStart();
string textoSemEspacosFim = texto.TrimEnd();

texto = "exemplo de texto";
bool comecaComExemplo = texto.StartsWith("exemplo");
bool terminaComTexto = texto.EndsWith("texto");
bool contemDe = texto.Contains("de");
bool contemFoo = texto.Contains("foo");
bool terminaComFoo = texto.EndsWith("foo");
bool comecaComFoo = texto.StartsWith("foo");

string[] palavras = {"Olá", "mundo", "!"};
string mensagem = string.Join(" ", palavras);

frase = "O rato roeu a roupa do rei de Roma";
palavras = frase.Split(" ");

// STRINGBUILDER -> embora ele não seja uma string, ele é uma classe separada, uma coisa diferente, mas a gente utiliza ele pra
// nos poupar a utilização da memória do computador
// Pensa que num ambiente profissional onde você vai ter milhares, milhões de transações, de requisições, de loops, imagine que
// você está fazendo um relatório e você vai recuperar informação, vai trabalhar aquela string, isso rodando em loop vai acabar
// com o desempenho do seu computador, do servidor, e é pra isso que o StringBuilder foi feito, no StringBuilder já não existe isso 
// e ele utiliza a memória de forma mais otimizada, então ele separa um espaço, vai usar aquele espaço, se aquele espaço acabar ele
// pode usar um outro espaço, mas manter aqui pra saber que a continuação disso está em outro lugar na memória, então ele é otimizado
// pra você fazer essas alterações
// E você pode iniciar ele já com algum valor ou você inicia aqui vazio e vai dando um Append, então o Append é o que faz você
// adicionar coisas no seu StringBuilder
// O Insert ele vai lá no index, lembra que começa com 0, e insere o valor que estou passando
// O Remove vou passar o index e o tamanho do que eu quero remover
// O Replace eu consigo substituir um valor por um novo valor
// Ele tem tudo muito parecido com a string, mas ele tem essa otimização da memória
// Mas, como quase tudo a gente utiliza string no final eu estou te mostrando um ToString, você vai pegar o conteúdo do StringBuilder
// e aí converter para string

StringBuilder sb = new StringBuilder("Olá, mundo!");

StringBuilder sb2 = new StringBuilder();
sb2.Append("Olá, ");
sb2.Append("mundo!");

sb = new StringBuilder("Olá, ");
sb.Append("mundo!");

sb = new StringBuilder("Olá, mundo!");
sb.Insert(5, "querido ");

sb = new StringBuilder("Olá, querido mundo!");
sb.Remove(5, 8);

sb = new StringBuilder("O rato roeu a roupa do rei de Roma");
sb.Replace("rato", "gato");

sb = new StringBuilder("Olá, mundo!");
string converteTexto = sb.ToString();
// Dicionário - Contagem de palavras: dado uma string temos como resultado final dizendo a palavra e a quantidade, o que
// temos que prestar atenção aqui é que espaços não contam, vírgula não conta, coisas que o algoritmo te daria
// A primeira coisa que a gente faz nesse código é pegar essa string e quebrar ela num array porque fica mais fácil de
// eu percorrê-la e eu faço isso através do Split, quando eu faço o Split eu falo olha utiliza isso aqui como separador
// e quando eu fizer isso vou ter um array de palavras dessa minha string todas separadas até o final, e aí vou fazer
// uma coisa bem simples cheguei no primeiro item do array e vou olhar se dentro do meu dicionário eu já tenho esse item
// se não existir vou adicionar esse item como chave e vou atribuir o valor 1 e ele vai fazendo essa verificação em nos
// demais itens, até chegamos num momento em que o item já vai estar contido no nosso dicionário nesse caso ele vai
// pegar o valor que ele tem dessa chave e vai incrementar mais 1, ao final retornamos o nosso dicionário com a contagem
// das palavras

string teste = "O rato roeu a roupa do rei de roma, a roupa do rei é preta";
var resultado = ContadorDePalavras(teste);

foreach (var item in resultado)
{
    Console.WriteLine($"{item.Key} = {item.Value}");
}

static Dictionary<string, int> ContadorDePalavras(string texto)
{
    Dictionary<string, int> contagem = new Dictionary<string, int>();
    string[] palavras = texto.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

    foreach (var palavra in palavras)
    {
        // Ele é case sensitive, ou seja, ele verifica a questão de maiúscula e minúscula, questão de acentuação
        var palavraMinuscula = palavra.ToLower();

        // Verificação para checar no meu dicionário se ele contém uma determinada chave
        if (contagem.ContainsKey(palavraMinuscula))
        {
            // Acessando o valor da chave e automaticamente incrementando o seu valor em mais 1
            contagem[palavraMinuscula]++;
        }
        else
        {
            // Se não tiver, ele vai adicionar a chave atribuindo o valor 1
            contagem[palavraMinuscula] = 1;
        }
    }
    
    // Retornando um dicionário com as chaves e os valores onde eu tenho cada palavra com o seu respectivo valor
    return contagem;
}
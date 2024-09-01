// Hashsets - anagramas: o algoritmo que a gente vai trabalhar é pegar palavras e verificar quais são feitas das mesmas
// letras, ou seja, são anagramas então a gente agrupa é um algoritmo de agrupamento, importante frisar que esse
// algoritmo só vai funcionar com palavras que não possuem letras repetidas
// A primeira coisa que a gente vai fazer é olhar a palavra individualmente e jogar no Hashset quando nós jogamos a
// palavra inteira aqui no Hashset o que vai acontecer é que o Hashset vai separar pra gente porque a gente vai falar
// com Hashset de caracter, e uma string nada mais é do que um conjunto de chars, e o que é mais interessante é que nós
// vamos utilizar outra estrutura de dados que é o dicionário onde eu vou dizer que o meu dicionário o tipo da chave
// dele é um Hashset de char e o valor é uma lista de strings

string[] palavras = { "bat", "tab", "cat", "act", "dog", "god" };

// O que estou falando aqui para o meu dicionário? Que o comparador dele vai ser o comparador que eu utilizo lá no
// Hashset porque na hora que estou fazendo o hash do meu dicionário ele pega o que você está colocando nele na chave
// passa para um hash que é um outro algoritmo pra sair uma outra string que é a que ele usa como índice, se eu não 
// falar nada ele vai utilizar o hash dele e o hash dele faz diferença entre BAT e TAB a ordem muda o resultado é
// diferente e eu não quero isso, eu quero que seja a mesma coisa BAT e TAB assim como é no meu Hashset então eu mando
// ele usar como comparador o comparador do Hashset de char porque para ele não importa a ordem ele sempre vai fazer da
// mesma forma
// Então, aqui a única coisa que eu estou fazendo é igualando o hash do dicionário ao hash do Hashset
Dictionary<HashSet<char>, List<string>> grupos = new Dictionary<HashSet<char>, List<string>>(HashSet<char>.CreateSetComparer());

// A partir desse momento vou passar de palavra em palavra no meu array de palavras
foreach (string palavra in palavras)
{
    // Criando um HashSet para os caracteres únicos da palavra
    HashSet<char> caracteres = new HashSet<char>(palavra);
    
    // Verificando se já existe um grupo com esses caracteres
    if (grupos.TryGetValue(caracteres, out List<string> grupoAtual))
    {
        // Adicionando a palavra ao grupo existente
        grupoAtual.Add(palavra);
    }
    else
    {
        // Criando um novo grupo para esses caracteres
        grupos[caracteres] = new List<string> { palavra };
    }
}

// Exibindo os grupos
foreach (var grupo in grupos)
{
    Console.WriteLine($"Grupo de caracteres [{string.Join(", ", grupo.Key)}]: {string.Join(", ", grupo.Value)}");
}

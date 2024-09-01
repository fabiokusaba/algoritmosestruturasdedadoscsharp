// Pilha - Parênteses Válidos: nessa aula vamos ver a stack que é a pilha estrutura de dados onde o último a entrar é o
// primeiro a sair e vamos ver ele com o algoritmo de parênteses válidos e este algoritmo serve para checar se uma
// determinada string dada respeita a questão dos parênteses válidos o importante é verificar se a ordem de abertura e
// fechamento bate, por exemplo "[{()}]"
// O que a gente vai fazer é muito simples a gente vai pegar uma pilha e a cada item que a gente verificar a gente vai
// colocando lá na pilha o que a gente espera encontrar no retorno então enquanto eu for encontrando abertura eu vou
// jogando o que eu preciso fechar lá na minha pilha, mas vai chegar um ponto que vai acontecer algo diferente é um
// caracter de abertura? Não, não é, ele é o que? Ele é fechamento, se ele é fechamento o que eu faço? Eu vou lá na
// minha pilha e olho se o próximo elemento, ou seja, se o primeiro elemento que eu tenho para retirar é igual a ele
// se eles são iguais ainda está tudo certo, ainda é válido

string teste = "[{()}]";
Console.WriteLine(ParentesesValidos(teste));

static bool ParentesesValidos(string s)
{
    Stack<char> caracteres = new Stack<char>();

    foreach (char c in s)
    {
        if (c == '(')
        {
            caracteres.Push(')');
        }
        else if (c == '[')
        {
            caracteres.Push(']');
        }
        else if (c == '{')
        {
            caracteres.Push('}');
        }
        else if (caracteres.Count == 0 || caracteres.Pop() != c)
        {
            return false;
        }
    }
    
    return caracteres.Count == 0;
}
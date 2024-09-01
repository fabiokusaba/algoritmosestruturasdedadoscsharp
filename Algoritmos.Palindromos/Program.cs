// Palíndromos -> é simplesmente uma palavra que se você lê ela de frente para trás ou de trás para frente ela vai ser a mesma
// para checar o palíndromo a gente vai utilizar uma coisa que eu acho muito interessante, a gente vai começar a trabalhar com
// dois ponteiros, como que eu vou resolver isso daqui? Vamos pegar como exemplo a palavra "arara" o que eu vou fazer é colocar
// um ponteiro no início e um ponteiro no fim e vou compará-los, o que está aqui no ponteiro inicial é uma letra que é igual ao
// que está no ponteiro final? Se for, está tudo certo, se for diferente já não é um palíndromo, se forem iguais você move o
// ponteiro inicial pra frente e o ponteiro final pra trás até eles se encontrarem e aí você continua comparando, quando eles se
// encontram quer dizer que eu já varri tudo que está para um lado, tudo que está para o outro, e só sobrou uma letra no meio e
// se só sobrou uma letra no meio é um palíndromo

string teste = "arara";
Console.WriteLine(ChecaPalindromo(teste));

static bool ChecaPalindromo(string s)
{
    int inicio = 0;
    int fim = s.Length - 1;

    while (inicio < fim)
    {
        // Olha o início com o fim
        if (s[inicio] != s[fim])
        {
            return false;
        }

        // Corre o ponteiro inicial para frente
        inicio++;

        // Corre o ponteiro final para trás
        fim--;
    }

    return true;
}

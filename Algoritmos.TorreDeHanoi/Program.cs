// Torres de Hanoi - recursão: 

foreach (var item in Hanoi(4, 'a', 'b', 'c'))
{
    Console.WriteLine(item);
}

// Criamos uma função Hanoi que recebe quatro parâmetros: o n que seria o número de peças, qual é a coluna inicial, a
// coluna auxiliar e a coluna final
static List<Tuple<char, char>> Hanoi(int n, char inicio, char auxiliar, char fim)
{
    // Criando uma lista para guardar as informações
    var lista = new List<Tuple<char, char>>();
    
    // A primeira informação que temos é que se o n for 2 eu vou retornar três pares de valores
    if (n == 2)
    {
        lista.Add(new Tuple<char, char>(inicio, auxiliar));
        lista.Add(new Tuple<char, char>(inicio, fim));
        lista.Add(new Tuple<char, char>(auxiliar, fim));
        
        return lista;
    }
    
    // Se o n não for 2 ele não vai fazer isso e é aqui que entra a recursão, ou seja, a lista vai ser igual ao retorno
    // que vem da função Hanoi com novos parâmetros
    // O primeiro parâmetro vai ser o n - 1, o início, o fim e por último o auxiliar
    lista = Hanoi(n -1, inicio, fim, auxiliar);
    
    // Você ainda adiciona um novo par de valor que seria o início e o fim
    lista.Add(new Tuple<char, char>(inicio, fim));
    
    // E você faz mais uma chamada a função Hanoi, aqui vou adicionar um AddRange porque eu vou trazer uma nova lista
    // dessa função e quero juntar a minha lista original
    // Atenção porque a ordem muda agora eu chamo primeiramente o auxiliar, o início e o fim
    lista.AddRange(Hanoi(n -1, auxiliar, inicio, fim));
    
    // No final retorno essa lista
    return lista;
}
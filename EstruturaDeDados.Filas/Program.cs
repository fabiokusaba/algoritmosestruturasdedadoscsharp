// Queue é a nossa fila, como funciona uma fila na vida real? O primeiro que entra é o primeiro que sai

var aluno1 = new Aluno(){Matricula = 1000, Nome = "José"};
var aluno2 = new Aluno(){Matricula = 1001, Nome = "Maria"};
var aluno3 = new Aluno(){Matricula = 1002, Nome = "Lucia"};
var aluno4 = new Aluno(){Matricula = 1003, Nome = "Marcos"};

// Declarando uma fila
Queue<Aluno> minhaQueue = new Queue<Aluno>();

// Enfileirando elementos, O(1) coloca mais um na fila e ele sabe onde ele vai por, ele vai colocar por último
minhaQueue.Enqueue(aluno3);
minhaQueue.Enqueue(aluno1);
minhaQueue.Enqueue(aluno2);
minhaQueue.Enqueue(aluno4);

// Desinfileirar, ou seja, chamando o próximo da fila/retirando da fila, O(1) ele pega sempre o primeiro
Aluno proximo = minhaQueue.Dequeue();

// Espiando, ou seja, descobrindo quem é o próximo da fila
Aluno espiaProximoAluno = minhaQueue.Peek();

// Verificando se a fila contém o elemento e aqui ele é O(n), então ele vai passar de um em um, pra ele saber se contém alguma
// coisa se fosse um integer, uma data, uma string, ou seja, algum tipo de classe/struct que ele já sabe, que já é do C# ele
// saberia como ver, eu sei ver se um número é igual ao outro para ver se ele está lá, eu sei verificar se uma string, um
// determinado nome é igual a uma string que já está lá, mas um Aluno eu não sei dizer, o compilador, o C# ele não sabe quando
// eu falo assim "esse aluno aqui 1003 Marcos ele está aí na fila?" o compilador não sabe o que fazer e pra isso a gente informa
// pra ele sobrescrevendo o método Equals da classe
bool contemElemento = minhaQueue.Contains(aluno1);

// Limpando a fila, ou seja, tirou todos da fila, também é O(n) porque ele precisa ir até o fim da fila limpando
minhaQueue.Clear();

// Quantidade de elementos na fila
int numeroElementos = minhaQueue.Count;

class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }

    // Toda vez que eu quiser saber se um Aluno é igual ao outro, então a gente sobrescreve o método Equals
    public override bool Equals(object? obj)
    {
        // Primeiro eu vejo se o objeto que eu estou comparando é igual ao primeiro da fila, se o objeto é nulo aqui eu já digo
        // que isso aqui é diferente porque eu não quero fazer uma comparação de nulo e já retorno falso
        if (obj == null) return false;

        // Aqui eu pego esse objeto que pode ser qualquer coisa, primeiro eu faço esse cast transformando esse objeto em Aluno
        // eu tento transformar ele em Aluno, repare que ele até deixa um alerta aqui porque essa transformação pode acarretar
        // esse outroAluno ser nulo porque eu recebi um objeto que é de outra classe qualquer, uma string, um inteiro, uma classe
        // Professor, e aí quando ele tenta converter Aluno ele não consegue e aí vai ser nulo, por isso verificamos se o outroAluno
        // o objeto que eu transformei em Aluno, é nulo então também não é igual e podemos retornar falso
        Aluno outroAluno = obj as Aluno;
        if (outroAluno == null) return false;

        // Se for um Aluno passamos para o último onde vamos verificar, efetivamente aqui a gente faz a comparação, então o this faz
        // referência ao Aluno que você está olhando, o this faz referência a própria instância, e ele vai comprar se a matrícula dessa
        // instância é igual a matrícula do outroAluno e o nome dessa instância é igual ao nome do outroAluno, se ambos forem iguais
        // devolve um true, se qualquer um desses dois for falso ele vai devolver um false
        return this.Matricula == outroAluno.Matricula && this.Nome == outroAluno.Nome;
    }
}
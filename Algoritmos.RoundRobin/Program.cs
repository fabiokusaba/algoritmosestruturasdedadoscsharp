// Filas - Round Robin: vamos criar um simulador de um escalonador round robin, esse escalonador vai pegar os processos
// que estão numa fila para serem executados e mandar para CPU executar o que tem que ser feito só que o escalonador ele
// tem que organizar as coisas, vamos dizer que o processo 1 vai demorar 100 unidades de tempo se eu pegar esse 
// processo e mandar lá pra CPU a CPU levaria o tempo 100 para executar esse processo e durante esse tempo o processo 2
// e processo 3 ficariam congelados isso não é legal num cenário multi-thread, num cenário de servidor no qual a gente
// precisa receber várias requisições e precisa dar conta de todas elas e aí a gente faz um pouquinho de cada e vai
// mudando, ou seja, faz um pouquinho da 2 muda pra 3 faz um pouquinho da 3 muda pra 1 e assim por diante, assim 
// nenhuma delas vai perceber que está esperando muito tempo porque imagina o processo 3 tendo que esperar o processo 2
// e o processo 1 finalizarem para poder começar
// E o que o escalonador faz? No nosso exemplo aqui ele vai dar um pedaço de tempo para cada processo, então digamos que
// a gente colocou lá um tempo de 3 então ele vai pegar o processo mandar para a CPU e contar se passaram 3 unidades de
// tempo se passou e o processo não terminou ele volta para a fila, só que o que vai acontecer com ele? Ele vai voltar
// para o fim da fila porque o próximo tem que ser executado

EscalonadorRoundRobin scheduler = new EscalonadorRoundRobin();

scheduler.AddProcesso(new Processo(){Id = 1, Descricao = "Chamada API", TempoDeProcessamento = 5});
scheduler.AddProcesso(new Processo(){Id = 2, Descricao = "Aguarda DB", TempoDeProcessamento = 12});
scheduler.AddProcesso(new Processo(){Id = 3, Descricao = "Imprime", TempoDeProcessamento = 3});

scheduler.Executar();

public class Processo
{
    public int Id { get; set; }
    // Tempo que o processo precisa para completar
    public int TempoDeProcessamento { get; set; }
    public string Descricao { get; set; }
}

public class EscalonadorRoundRobin
{
    private Queue<Processo> queue = new Queue<Processo>();
    // Define o tempo dado pelo "processador" para cada processo
    private const int TEMPO_CLOCK = 3;

    public void AddProcesso(Processo processo)
    {
        queue.Enqueue(processo);
    }

    public void Executar()
    {
        while (queue.Count > 0)
        {
            // Retiro alguém da fila, por se tratar de uma fila o primeiro a entrar vai ser o primeiro que vou retirar
            var processo = queue.Dequeue();
            Console.WriteLine($"Executando processo {processo.Id}");

            if (processo.TempoDeProcessamento > TEMPO_CLOCK)
            {
                processo.TempoDeProcessamento -= TEMPO_CLOCK;
                Console.WriteLine($"Processo {processo.Id}-{processo.Descricao} interrompido após {TEMPO_CLOCK} unidades de tempo.");
                // Reenfileira o processo se ele ainda não foi concluído
                queue.Enqueue(processo);
            }
            else
            {
                Console.WriteLine($"Processo {processo.Id} concluído após {processo.TempoDeProcessamento} unidades de tempo.");
            }
        }
    }
}
// Listas ligadas - inversão: ela vai de um ponto a outro e vamos revertê-la, ou seja, vamos fazer ela ir do fim até
// o início, quando a gente for inverter a lista a gente vai receber ela aqui e a gente vai passar item a item dessa
// lista só que a gente vai jogar em uma outra lista só que ao invés da gente adicionar por último com AddLast a gente
// vai colocar em primeiro com AddFirst e aí automaticamente vai ficando invertida na ordem

LinkedList<int> teste = new LinkedList<int>();
teste.AddLast(2);
teste.AddLast(1);
teste.AddLast(4);
teste.AddLast(3);
teste.AddLast(6);
teste.AddLast(5);
teste.AddLast(8);
teste.AddLast(7);
teste.AddLast(9);
Console.WriteLine();

var listaReversa = ReverteLinkedList(teste);
Console.WriteLine();

static LinkedList<int> ReverteLinkedList(LinkedList<int> lista)
{
    LinkedList<int> reversa = new LinkedList<int>();

    foreach (var item in lista)
    {
        // Adicione itens no início para inverter
        reversa.AddFirst(item);
    }

    return reversa;
}
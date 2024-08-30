// Stack é o que a gente chamaria de pilha, pilha de coisas que a gente empilha, vamos dizer que a gente está lavando pratos e
// a gente colocou um prato em cima do outro, uma pilha de pratos, e o que acontece numa pilha de pratos? Se a gente fez a nossa
// pilha aqui qual é o mais fácil para pegar? A gente vai pegar o último prato que a gente empilhou, então a pilha é uma caso no
// qual o último a ser colocado é o primeiro a ser retirado, esse comportamento a gente chama de LIFO (last in first out), um
// exemplo que podemos pensar aqui é o CTRL+Z, o que ele faz? Ele vai desfazendo as últimas coisas que eu fiz, o histórico de 
// navegação funciona da mesma forma, quando você vai voltar você volta do último para o primeiro, então sempre que você tiver um
// problema em que você precisa ir na sequência e voltar na ordem do último para o primeiro a pilha vai ser a sua estrutura de dados

Stack<int> stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);

int numberOfElements = stack.Count;

int removedElement = stack.Pop();

int lastElement = stack.Peek();

bool containsElement = stack.Contains(20);

stack.Clear();
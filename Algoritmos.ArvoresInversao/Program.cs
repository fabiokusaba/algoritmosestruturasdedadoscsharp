// Árvores - inversão: inverter a árvore é simplesmente fazer isso aqui o meu nó raiz não tem como inverter por ele ser
// o primeiro então ele permanece lá, aí a gente inverte o esquerdo e direito desse raiz, aí a gente desce um nível e
// vai invertendo cada nível até chegar no final

ArvoreBinaria.Nó no = new(1);
no._nóEsquerdo = new ArvoreBinaria.Nó(2);
no._nóEsquerdo._nóEsquerdo = new ArvoreBinaria.Nó(4);
no._nóEsquerdo._nóDireito = new ArvoreBinaria.Nó(5);

no._nóDireito = new ArvoreBinaria.Nó(3);
no._nóDireito._nóEsquerdo = new ArvoreBinaria.Nó(6);
no._nóDireito._nóDireito = new ArvoreBinaria.Nó(7);

ArvoreBinaria.Nó invertido = inverte(no);

Console.WriteLine();

ArvoreBinaria.Nó inverte(ArvoreBinaria.Nó no)
{
    // Fator que vai me tirar da recursão, então vamos primeiro começar pelo final se o nó que eu passei for nulo, ou
    // seja, se ele não tiver nenhum valor ou o esquerdo e o direito forem nulos, ou seja, eu não tenho nada abaixo dele
    // então eu retorno apenas o nó
    if (no is null || (no._nóEsquerdo is null && no._nóDireito is null))
    {
        return no;
    }

    // Utilizando recursão, aqui eu fiz um tempNo porque em algum momento iremos trabalhar com uma questão de swap, ou
    // seja, troca, então eu preciso inverter mas eu preciso guardar ele em algum canto pra poder trocar se não na hora
    // que eu tentar destrocar vou ter perdido o valor original
    ArvoreBinaria.Nó tempNo = no._nóDireito;
    
    // Aqui ele vai falar inverte o nó esquerdo, agora estou falando que o direito do meu nó raiz é igual o nó esquerdo
    // invertido, então já estou dizendo que o que vai vir para o lado direito é o nó esquerdo invertido, de primeira
    // já mudei um lado com o outro e ainda mandei inverter o que está dentro dele
    no._nóDireito = inverte(no._nóEsquerdo);
    
    // Ele ainda tem o lado esquerdo para arrumar e o que ele falou no lado esquerdo? Pega o que tem no temp inverte e
    // joga aqui
    no._nóEsquerdo = inverte(tempNo);

    return no;
}

public class ArvoreBinaria
{
    public class Nó
    {
        internal int _valor;
        internal Nó _nóEsquerdo;
        internal Nó _nóDireito;

        public Nó(int valor)
        {
            _valor = valor;
        }

        public override string ToString()
        {
            return $"Nó={_valor}";
        }
    }

    public Nó raiz;

    public void Inserir(int valor)
    {
        var novoNó = new Nó(valor);

        if (raiz == null)
        {
            raiz = novoNó;
            return;
        }

        var nóAtual = raiz;
        while (true)
        {
            if (valor < nóAtual._valor)
            {
                if (nóAtual._nóEsquerdo == null)
                {
                    nóAtual._nóEsquerdo = novoNó;
                    return;
                }
                else
                {
                    nóAtual = nóAtual._nóEsquerdo;
                }
            }
            else if (valor > nóAtual._valor)
            {
                if (nóAtual._nóDireito == null)
                {
                    nóAtual._nóDireito = novoNó;
                    return;
                }
                else
                {
                    nóAtual = nóAtual._nóDireito;
                }
            }
        }
    }
}
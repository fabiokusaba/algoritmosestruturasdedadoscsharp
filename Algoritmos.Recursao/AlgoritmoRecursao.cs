namespace Algoritmos.Recursao;

public static class AlgoritmoRecursao
{
    public static void Executar()
    {
        Console.WriteLine(Fibonacci(3));
    }

    // O fatorial de um número para quem não conhece é algo que a gente utiliza na matemática, por exemplo o fatorial de
    // 3 é igual a 3 vezes fatorial de 2, e o que é o fatorial de 2? É 2 vezes o fatorial de 1 e o fatorial de 1 é ele
    // mesmo, ou seja, 1, no fim é como se a gente multiplicasse um número por todos os seus antecessores, ou seja,
    // 3 * 2 * 1
    public static int Fatorial(int numero)
    {
        // A primeira coisa que eu coloco é o nosso caso base para que quando ele for atingido eu saia desse loop
        // recursivo
        if (numero <= 1)
        {
            return 1;
        }
        
        // Se não for, vou pegar o número e multiplicar pelo fatorial do número anterior a ele
        return numero * Fatorial(numero - 1);
    }
    
    // Fibonacci também é uma coisa da matemática onde você pega um número e o fibonacci desse número é a soma dos
    // fibonacci dos dois números anteriores, então o fibonacci de 3 é a soma do fibonacci de 2 com o fibonacci de 1
    // 
    public static int Fibonacci(int numero)
    {
        // O caso base dos fibonacci é assim: se o número que você está passando for 0 retorna 0, ou seja, o fibonacci
        // de 0 já é 0
        if (numero == 0)    
        {
            return 0;
        }

        // O fibonacci de 1 ou de 2 é 1
        if (numero == 1 || numero == 2)
        {
            return 1;
        }
        
        // E qualquer outro número que não seja esse o resultado é: fibonacci do número anterior mais o fibonacci de
        // dois números antes, ou seja, nós estamos aqui no 3 então o fibonacci de 3 vai ser a soma do fibonacci de 2
        // com a soma do fibonacci de 1
        return Fibonacci(numero - 1) + Fibonacci(numero - 2);
    }
}
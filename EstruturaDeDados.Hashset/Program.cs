// Hashset você pode pensar como conjuntos, o conjunto que vem da matemática, ele também é generic aceitando diversos tipos
// pensa no conjunto como sendo uma coleção que só pode ter um item de cada tipo, ou seja, não dá pra repetir, são únicos, o
// conjunto vai utilizar aqui, com o próprio nome diz, uma função de hash pra transformar cada item específico em um código de
// hash que vai ajudar não somente ele a saber que é único mas também ele localizar de forma muito rápida, então a grosso modo
// tudo o que a gente fizer com hash a complexidade vai ser O(1) porque através do hash ele consegue achar rapidamente

var hashset = new HashSet<int>();
hashset.Add(1);
hashset.Add(2);

// Se tentarmos adicionar um item repetido ele não vai dar erro, mas também não irá adicionar esse item
hashset.Add(2);
hashset.Add(3);

if (hashset.Contains(2))
{
    Console.WriteLine("O hashset contém o número 2.");
}

if (hashset.Remove(2))
{
    Console.WriteLine("O número 2 foi removido do hashset.");
}

var hashset1 = new HashSet<int>{1, 2, 3};
var hashset2 = new HashSet<int>{2, 3, 4};

// hashset1 agora contém os elementos {1, 2, 3, 4}, aqui ele não vai pegar os elementos que já possui, mas sim os elementos que ainda
// não possui que no caso foi o 4 do hashset2
hashset1.UnionWith(hashset2);

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{2, 3, 4};

// hashset1 agora contém os elementos {2, 3}, aqui ele vai pegar o que é comum em ambos os hashsets
hashset1.IntersectWith(hashset2);

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{2, 3, 4};

// hashset1 agora contém os elementos {1}, como estou utilizando como base o hashset1 só vai sobrar o que tiver no hashset1 que não
// tiver no hashset2
hashset1.ExceptWith(hashset2);

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{2, 3, 4};

// hashset1 agora contém os elementos {1, 4}, aqui é o que tem em um que não tem no outro e aí não interessa daonde você está chamando
// ele vai olhar tudo o que tem no 1 que não tem no 2, e vai pegar o 2 e olhar tudo o que tem no 2 que não tem no 1
hashset1.SymmetricExceptWith(hashset2);

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{2, 3, 4};

// O Overlaps vai mostrar se parte do hashset1 é encontrado no hashset2
if (hashset1.Overlaps(hashset2))
{
    Console.WriteLine("Os hashsets têm elementos em comum.");
}

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{1, 2, 3, 4, 5};

// O que é um subset? Um subset seria o seguinte: set é conjunto, então ele está verificando se o primeiro conjunto ele é um subset
// do segundo conjunto, se o segundo conjunto contém esse primeiro conjunto
if (hashset1.IsSubsetOf(hashset2))
{
    Console.WriteLine("O hashset1 é um subconjunto do hashset2.");
}

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{1, 2, 3, 4, 5};

// Já o ProperSubset significa que no segundo conjunto sendo olhado tem todos os elementos do primeiro conjunto mas tem algum a mais
if (hashset1.IsProperSubsetOf(hashset2))
{
    Console.WriteLine("O hashset1 é um subconjunto próprio do hashset2.");
}

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{1, 2};

// Superset seria o contrário do Subset, no caso ele perguntou hashset1 é Superset do hashset2, ou seja, o meu primeiro conjunto aqui
// {1, 2, 3} ele é um superconjunto do {1, 2}, como ele é um superconjunto? Quando o conjunto que eu estou perguntando está dentro dele
if (hashset1.IsSupersetOf(hashset2))
{
    Console.WriteLine("O hashset1 é um superconjunto do hashset2.");
}

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{1, 2};

// E a mesma coisa aqui, ProperSuperset, só é ProperSuperset se o primeiro tiver todos os elementos do segundo mais algum outro item
if (hashset1.IsProperSupersetOf(hashset2))
{
    Console.WriteLine("O hashset1 é um superconjunto próprio do hashset2.");
}

hashset1 = new HashSet<int>{1, 2, 3};
hashset2 = new HashSet<int>{3, 2, 1};

// Por fim, o SetEquals ele vai verificar se os conjuntos são iguais, aqui eles estão dispostos em ordem diferente porque no conjunto
// a ordem não importa o que conta é o número dos elementos e os elementos em si
if (hashset1.SetEquals(hashset2))
{
    Console.WriteLine("Os hashsets têm os mesmos elementos.");
}
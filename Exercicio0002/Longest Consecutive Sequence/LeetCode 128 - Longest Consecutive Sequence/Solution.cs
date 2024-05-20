//Dada uma array não classificada de números inteiros,
//retorne o comprimento da sequência de elementos
//consecutivos mais longa.

//exemplo 1: Input: nums = [100,4,200,1,3,2] | Output: 4
//A sequência mais longa é [1, 2, 3, 4], seu comprimento é 4.

//exemplos 2: Input: nums = [0,3,7,2,5,8,4,6,0,1] | Output: 9

public class Solution
{
    //aqui criamos nosso int que receberá os ints chamados nums
    public int LongestConsecutive(int[] nums)
    {
        //vamos usar um HashSet, ele não mantém a ordem dos elementos,
        //usa o mecanismo de hash para guardar os elementos, pode conter
        //valores nulos, há outros detalhes mais técnicos, mas não é o
        //objetivo descrever toda a engenharia da função, o mais
        //interessante aqui é que ele armazena apenas elementos
        //exclusivos, se vier algo repetido, ele salva só 1x.
        HashSet<int> set = new HashSet<int>(nums);
        int tamanhoMax = 0;

        //Lá no LeetCode, há um ranqueamento por eficiência de código,
        //não basta funcionar, eu tentei com ifs e arrays, mas ficou
        //bem "ineficiente" no rank, então coloquei um foreach
        //que parecia mais rápido.
        foreach (int num in set)
        {
            //aqui verificamos se já não há um deste no set.
            if (set.Contains(num - 1)) continue;

            int tamanho = 0;
            //verificamos aqui se num+tamanho existe no set,
            //se existir, aumenta em 1 a quantidade em tamanho.
            //Enquanto o elemento num+tamanho estiver no conjunto,
            //o loop seguirá repetindo.
            while (set.Contains(num + tamanho)) tamanho++;

            //aqui comparamos o maior de ambos e salvamos em
            //tamanhoMax para logo em seguida retornarmos ele.
            tamanhoMax = Math.Max(tamanhoMax, tamanho);
        }

        return tamanhoMax;
    }
}

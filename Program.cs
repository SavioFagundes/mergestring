
using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder resultado = new StringBuilder();
        int i = 0, j = 0;

        while (i < word1.Length && j < word2.Length)
        {
            resultado.Append(word1[i++]);
            resultado.Append(word2[j++]);
        }

        while (i < word1.Length)
        {
            resultado.Append(word1[i++]);
        }
        while (j < word2.Length)
        {
            resultado.Append(word2[j++]);
        }
        return resultado.ToString();
    }
    public static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.MergeAlternately("abc", "pqr"));     // apbqcr
        Console.WriteLine(sol.MergeAlternately("ab", "pqrs"));     // apbqrs
        Console.WriteLine(sol.MergeAlternately("abcd", "pq"));     // apbqcd
    }
}

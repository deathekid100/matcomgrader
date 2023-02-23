using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static long BS(List<long> a, int n, long X)
    {
        long ans = 0;
        long currentSum = 0;
        int L = 0, R = 0;
        while (R < n)
        {
            currentSum += a[R];
            while (currentSum > X)
            {
                currentSum -= a[L++];
            }
            ans += R - L + 1;
            R++;
        }
        return ans;
    }

    public static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToList();
        int n = input[0], q = input[1];
        var a = Console.ReadLine().Split().Select(long.Parse).ToList();
        var qi = Console.ReadLine().Split().Select(long.Parse).ToList();
        for (int i = 0; i < q; i++)
        {
            Console.WriteLine(BS(a, n, qi[i]));
        }
    }
}

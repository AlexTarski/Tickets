using System;
using System.Numerics;

namespace Tickets;

public static class TicketsTask
{
    public static BigInteger Solve(int halfLen, int totalSum)
    {
        if (halfLen == 0) throw new ArgumentOutOfRangeException
                (nameof(halfLen), "The half-length of the lucky ticket number can't be less than 1.");

        if (totalSum % 2 != 0)
            return BigInteger.Zero;

        if (totalSum / 2 == halfLen * 9)
            return BigInteger.One;

        BigInteger[,] countingTable = new BigInteger[totalSum / 2 + 1, halfLen];
        FillTable(countingTable, totalSum, halfLen);

        return countingTable[totalSum / 2, halfLen - 1] * countingTable[totalSum / 2, halfLen - 1];
    }

    private static void FillTable(BigInteger[,] countingTable,  int totalSum, int halfLen)
    {
        for (int i = 0; i < 10; i++)
        {
            if (i > totalSum / 2)
            {
                break;
            }
            countingTable[i, 0] = BigInteger.One;
        }

        for (int n = 1; n < halfLen; n++)
        {
            for (int k = 0; k <= (n + 1) * 9; k++)
            {
                if (k > totalSum / 2)
                {
                    break;
                }
                else
                {
                    countingTable[k, n] = Sum(countingTable, k - 9, k, n - 1);
                }
            }
        }
    }
    
    private static BigInteger Sum (BigInteger[,] countingTable, int begin, int end, int column)
    {
        begin = begin < 0 ? 0 : begin;
        BigInteger result = 0;
        for (; begin <= end; begin++)
        {
            result += countingTable[begin, column];
        }

        return result;
    }
}
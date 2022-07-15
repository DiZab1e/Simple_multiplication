using System;
public class Multiplier
{
    public static int Multiply(int x)
    {
        int z = x % 2;
        if (z == 0)
        {
            x = x * 8;
        }
        else
        {
            x = x * 9;
        }
        return x;
    }
}
using System;

public class Program
{
    int x;
    int Up(int[] a, int pos, int n)
    {
        int x;
        if (pos < n)
        {
            Console.WriteLine("Invalid Operation");
        }
        else
        {
            x = pos - n;
            a[x] = 1;
            a[pos] = 0;
            pos = x;
        }
        return pos;
    }

    int Down(int[] a, int pos, int n)
    {

        if (pos >= n * (n - 1))
        {
            Console.WriteLine("\nInvalid Operation\n");
        }
        else
        {
            x = pos + n;
            a[x] = 1;
            a[pos] = 0;
            pos = x;
        }
        return pos;
    }

    int Left(int[] a, int pos, int n)
    {
        if ((pos % n) == 0)
        {
            Console.WriteLine("\nInvalid Operation\n");
        }
        else
        {
            x = pos - 1;
            a[x] = 1;
            a[pos] = 0;
            pos = x;
        }
        return pos;
    }

    int Right(int[] a, int pos, int n)
    {
        if (((pos + 1) % n))
        {
            Console.WriteLine("\nInvalid Operation\n");
        }
        else
        {
            x = pos + 1;
            a[x] = 1;
            a[pos] = 0;
            pos = x;
        }
        return pos;
    }


    static void disp(int[] a,int n)
    {
        int count = 0;
        Console.WriteLine("\nMatrix is: \n");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            if (count < n)
            {
                Console.Write(a[i] + "\t");
                count++;
            }
            else
            {
                Console.Write("\n");
                Console.Write(a[i] + "\t");
                count = 1;
            }
        }
        Console.Write("\n");
    }



    static public void Main(string[] args)
    {
        Program P = new Program();
        int n, pos;
        Console.WriteLine("\nEnter array size:\n");
        n = Convert.ToInt32(Console.ReadLine());
        int size = n * n;
        int[] a = new int[size];

        Console.WriteLine("\nEnter array elements = \n");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            a[i] = 0;
        }
        pos = n * (n - 1);
        a[pos] = 1;


        int ch;
        do
        {
            Console.Write("2.For UP  \n 8.For DOWN  \n 4.For LEFT  \n 6.For RIGHT \n 0.For Display \n 1.For Exit");
            Console.WriteLine("\nEnter choice");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 2:
                    pos = P.Up(a, pos, n);
                    break;
                case 4:
                    pos = P.Left(a, pos, n);
                    break;
                case 6:
                    pos = P.Right(a, pos, n);
                    break;
                case 8:
                    pos = P.Down(a, pos, n);
                    break;
                case 0:
                    disp(a,n);
                    break;
                case 1:
                    break;
                default:
                    Console.WriteLine("\nEnter correct choice\n");
                    break;
            }
        } while (ch != 1);

    }

}

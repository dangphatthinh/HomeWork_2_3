using System;

class Program
{   
    public static void Main()
    {
        Board b = new Board();
        Data d = new Data();
        Console.WriteLine("Nhap kich thuoc Board: ");
        b.Size = int.Parse(Console.ReadLine());
        d.ResetArr(d.arr, b.Size);
        b.DrawBoard(d.arr,b.Size);
    }
}
class Data
{
    public int[,] arr = new int[100, 100];
    public void ResetArr(int[,] arr,int n)
    {
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                arr[i,j] = 32;
            }           
        }
    }
}
class Board
{
    private int size;
    public int Size { 
        get { return size; }
        set { size = value; }
    }
    
    public void DrawBoard(int[,] arr,int size)
    {
        for(int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("   {0}   ", (char)arr[i,j]);
                if(j == size - 1)
                {
                    break;
                }
                Console.Write("|");
            }
            Console.WriteLine();
            if (i == size - 1)
            {
                break;
            }
            for (int k = 0; k < size; k++)
            {
                Console.Write("-------");
                if (k == size - 1)
                {
                    break;
                }
                Console.Write("*");
            }
            Console.WriteLine();
        }      
    }
}
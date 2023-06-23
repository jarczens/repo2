using System;

class Triangle
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int height = Convert.ToInt32(Console.ReadLine());

        DrawTriangle(height);
    }

    static void DrawTriangle(int height)
    {
        int width = 2 * height - 1;
        int midpoint = width / 2;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (col >= midpoint - row && col <= midpoint + row)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("  ");
                }
            }

            Console.WriteLine();
        }
    }
}
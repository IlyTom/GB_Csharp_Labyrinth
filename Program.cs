namespace Labyrinth
{
    internal class Program
    {
        static int[,] labirynth1 = new int[,]
    {
        {1, 1, 1, 1, 1, 1, 1 },
        {1, 0, 0, 0, 0, 0, 1 },
        {1, 0, 1, 1, 1, 0, 1 },
        {0, 0, 0, 0, 1, 0, 2 },
        {1, 1, 0, 0, 1, 1, 1 },
        {1, 1, 1, 0, 1, 1, 1 },
        {1, 1, 1, 2, 1, 1, 1 }
    };

        static int[] dx = { -1, 0, 1, 0 };
        static int[] dy = { 0, 1, 0, -1 };
        static int count = 0;

        static void HasExit(int x, int y, int[,] l)
        {
            if (x < 0 || y < 0 || x >= l.GetLength(0) || y >= l.GetLength(1)) return;
            if (l[x, y] == 1) return;
            if ((x == 2 || y == 2 || x == l.GetLength(0) - 1 || y == l.GetLength(1) - 1) && l[x, y] == 2) count++;
            l[x, y] = 1;
            for (int i = 0; i < 4; i++)
            {
                HasExit(x + dx[i], y + dy[i], l);
            }
        }
        static void Main(string[] args)
        {
            HasExit(3, 0, labirynth1);
            Console.WriteLine($"Кол-во выходов {count}");
        }
    }
}
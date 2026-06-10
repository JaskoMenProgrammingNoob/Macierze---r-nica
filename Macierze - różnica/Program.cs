class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int[,] macierz = new int[n, n];
        int[,] macierza = new int[n, n];
        int[,] macierzroznica = new int[n, n];
        Console.WriteLine("     Macierz A: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierz[i, j] = 1;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{macierz[i, j],2}");
            }
            Console.WriteLine();
        }


        Console.WriteLine("     Macierz B: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierza[i, j] = 2;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{macierza[i, j],2}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("   Różnica macierzy A i B:  ");
        for ( int i = 0; i < n; i++)
        {
            for ( int j = 0; j < n; j++)
            {
                macierzroznica[i, j] = macierza[i, j] - macierz[i, j];


            }
           
        }
        for (int i = 0; i < n; i++)
        {
            for ( int j = 0; j < n; j++)
            {
                Console.Write($"{macierzroznica[i, j],2}");
            }
            Console.WriteLine();
        }
    }
}
using System . Diagnostics ;

namespace AlgoSamsung.Sort_collection ;

public class Program
{
    static void PrintArray ( int [ ] a , int n ) {

        for ( int i = 1 ; i <= n ; i ++ )
        {
            Console.Write ( $"{a[i]}" );
        }
        Console.WriteLine ( );
    }


    static void SelectionSort ( int [ ] a , int n ) {
        
        Console.WriteLine("Selection Sort");
        
        for ( int i = 1 ; i <= n - 1 ; i++)
        {
            int minIdx = i ;
            for ( int j = i + 1 ; j <= n ; j ++ )
            {
                if ( a[j] < a[minIdx] )
                {
                    minIdx = j ;
                }
            }

            int temp = a [ i ] ;
            a [ i ] = a [ minIdx ] ;
            a [ minIdx ] = temp ;

        }
    }
    
    static void InsertionSort ( int [ ] a , int n ) {
        
        Console.WriteLine("Insertion Sort");
        
        for ( int i = 2 ; i <= n ; i ++ )
        {
            int key = a [ i ] ;
            int j = i - 1 ;
            while ( j > 0 && a [ j ] > key )
            {
                a [ j + 1 ] = a [ j ] ;
                j = j - 1 ;
            }
            a [ j + 1 ] = key ;
        }
    }
    static void BubbleSort ( int [ ] a , int n ) {
        
        Console.WriteLine("Bubble Sort");
        
        for ( int i = 1 ; i <= n - 1 ; i ++ )
        {
            for ( int j = 1 ; j <= n - i ; j ++ )
            {
                if ( a [ j ] > a [ j + 1 ] )
                {
                    int temp = a [ j ] ;
                    a [ j ] = a [ j + 1 ] ;
                    a [ j + 1 ] = temp ;
                }
            }
        }
    }


    public static void Main ( string [ ] args ) {

        Random rand = new Random ( ) ;
        Stopwatch stopwatch = new Stopwatch ( ) ;

        for ( int n = 10000 ; n <= 100000 ; n += 10000 )
        {
            Console.WriteLine($"n = {n}");
            
            // Khởi tạo mảng
            int[] a = new int[n + 5];
            int[] b = new int[n + 5];
            int[] c = new int[n + 5];

            for (int i = 1; i <= n; i++)
            {
                a[i] = rand.Next(1, 10001); // 1 to 10000
                b[i] = a[i];
                c[i] = a[i];
            }

            // Insertion sort
            stopwatch.Reset();
            stopwatch.Start();
            InsertionSort(a, n);
            stopwatch.Stop();
            Console.WriteLine($"Insertion sort: {stopwatch.Elapsed.TotalSeconds:F10} second");

            // Selection sorta
            stopwatch.Reset();
            stopwatch.Start();
            SelectionSort(b, n);
            stopwatch.Stop();
            Console.WriteLine($"Selection sort: {stopwatch.Elapsed.TotalSeconds:F10} second");

            // Bubble sort
            stopwatch.Reset();
            stopwatch.Start();
            BubbleSort(c, n);
            stopwatch.Stop();
            Console.WriteLine($"Bubble sort: {stopwatch.Elapsed.TotalSeconds:F10} second");

            Console.WriteLine("--------------------------------------------------------");
        }

        Console . ReadKey ( ) ;  
    }
    
}
    
    
    

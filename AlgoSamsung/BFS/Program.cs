namespace AlgoSamsung.BFS ;

public class Program
{
    public static void Main2 ( string [ ] args ) {
        
        
        Graph g = new Graph ( 4 ) ;
        g.Add ( 0 ,1  );
        g.Add ( 0 , 2 ) ;
        g.Add ( 1 , 2 ) ;
        g.Add ( 2 , 3 ) ;
        Console.WriteLine("do thi :");
        for ( int i = 0 ; i < 4 ; i ++ )
        {
            Console.Write($"dinh {i} : ");
            foreach ( var item in g . adj [ i ] )
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("Bài 1 -------- kiem tra tinh lien thong :");
        bool check = g . check ( ) ;
        if ( check ) Console.WriteLine("do thi lien thong ");
        else Console.WriteLine("do thi khong lien thong ");
        
        Console.WriteLine("Bài 2 -------- tim duong di ngan nhat:");
        int start = 0 , end = 3 ;
        int shortedPath = g . ShortedPath ( start , end ) ;
        
        if ( shortedPath != -1) Console.WriteLine($"duong di ngan nhat tu {start} den {end} la {shortedPath}");
        else Console.WriteLine($"khong co duong di ngan nhat  {start} den  {end}");

        Console . ReadKey ( ) ;

    }
}
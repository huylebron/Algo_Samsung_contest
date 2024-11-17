namespace AlgoSamsung . BFS ;

public class Graph
{
    private readonly int V ; // so dinh  
    public List < int > [ ] adj ; // danh sach ke

    // khoi tao 

    public Graph ( int v ) {
        V = v ;

        adj = new List < int > [ V ] ;
        for ( var i = 0 ; i < V ; i ++ ) adj [ i ] = new List < int > ( ) ;
    }

    // them canh vao do thi 

    public void Add ( int v , int w ) {
        // do thi vo hướng 
        adj [ v ] . Add ( w ) ;
        adj [ w ] . Add ( v ) ;
    }

    //check lien thong BFS 
    public bool check ( ) {
        // mảng đánh dáu các đỉnh đã duyệt qua 
        var visit = new bool [ V ] ;

        // tu dinh 0 

        BFS ( 0 , visit ) ;
        //check xem đỉnh nào chưa duyệt qua
        for ( var i = 0 ; i < V ; i ++ )
            if ( ! visit [ i ] )
                return false ;

        return true ;
    }

    // bài 2 tìm đường di ngan nhất 
    public int ShortedPath ( int start , int end ) {
        var visit = new bool [ V ] ;

        // mang lưu khoảng cách tu đỉnh xuất phát 

        var distance = new int [ V ] ;
        for ( var i = 0 ; i < V ; i ++ )
        {
            distance [ i ] = int . MaxValue ;

            // khai báo queue cho BFS

            var queue = new Queue < int > ( ) ;

            // khoi tao dinh bat dau 

            visit [ start ] = true ;
            distance [ start ] = 0 ;
            queue . Enqueue ( start ) ;


            while ( queue . Count > 0 )
            {
                var u = queue . Dequeue ( ) ;

                // neu tim thay 

                if ( u == end ) return distance [ u ] ;

                // duyet cac dinh ke voi u

                foreach ( var v in adj [ u ] )
                    if ( ! visit [ v ] )
                    {
                        visit [ v ] = true ;
                        distance [ v ] = distance [ u ] + 1 ;
                        queue . Enqueue ( v ) ;
                    }
            }
        }

        return -1 ;
    }

    // BFS kiem tra tinh lien thong 

    public void BFS ( int s , bool [ ] visit ) {
        var queue = new Queue < int > ( ) ;
        visit [ s ] = true ;
        queue . Enqueue ( s ) ;

        while ( queue . Count > 0 )
        {
            s = queue . Dequeue ( ) ;
            Console . WriteLine ( $"Visited node: {s}" ) ;
            foreach ( var v in adj [ s ] )
                if ( ! visit [ v ] )
                {
                    visit [ v ] = true ;
                    queue . Enqueue ( v ) ;
                    Console . WriteLine ( $"Edge: {s} -> {v}" ) ;
                }
        }
    }
}
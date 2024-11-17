using System . Diagnostics ;

namespace AlgoSamsung.BFS ;

public class Program2
{
    public static void Main ( string [ ] args ) {
        
        var testCases = new[]
        {
            new { Vertices = 100, Edges = 200 },
            new { Vertices = 500, Edges = 1000 },
            new { Vertices = 1000, Edges = 2000 },
            new { Vertices = 5000, Edges = 10000 },
            new { Vertices = 10000, Edges = 20000 }
        };

        Console.WriteLine("|--------------------|------------|------------|------------|");
        Console.WriteLine("|      Test Case     |  Vertices  |   Edges    |   Time(ms) |");
        Console.WriteLine("|--------------------|------------|------------|------------|");

        foreach (var test in testCases)
        {
            // Tạo đồ thị cho mỗi test case
            GrapTest g = new GrapTest(test.Vertices);
            g.GenerateRandomGraph(test.Edges);

            // Đo thời gian cho BFS
            Stopwatch swBFS = new Stopwatch();
            swBFS.Start();
            g.BFS(0);
            swBFS.Stop();

            // Đo thời gian cho DFS
            Stopwatch swDFS = new Stopwatch();
            swDFS.Start();
            g.DFS(0);
            swDFS.Stop();

            // In kết quả
            Console.WriteLine($"| BFS Test Case {Array.IndexOf(testCases, test) + 1}   | {test.Vertices,10} | {test.Edges,10} | {swBFS.ElapsedMilliseconds,10} |");
            Console.WriteLine($"| DFS Test Case {Array.IndexOf(testCases, test) + 1}   | {test.Vertices,10} | {test.Edges,10} | {swDFS.ElapsedMilliseconds,10} |");
            Console.WriteLine("|--------------------|------------|------------|------------|");
            Console . ReadKey ( ) ;
        }
    }
        
}

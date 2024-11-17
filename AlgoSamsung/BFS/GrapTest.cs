namespace AlgoSamsung.BFS ;

public class GrapTest
{
    private int V;
    private List<int>[] adj;

    public GrapTest (int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    // BFS
    public void BFS(int start)
    {
        bool[] visited = new bool[V];
        Queue<int> queue = new Queue<int>();

        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            int s = queue.Dequeue();

            foreach (int adjacent in adj[s])
            {
                if (!visited[adjacent])
                {
                    visited[adjacent] = true;
                    queue.Enqueue(adjacent);
                }
            }
        }
    }

    // DFS
    public void DFS(int start)
    {
        bool[] visited = new bool[V];
        DFSUtil(start, visited);
    }

    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;

        foreach (int adjacent in adj[v])
        {
            if (!visited[adjacent])
                DFSUtil(adjacent, visited);
        }
    }

    // Tạo đồ thị ngẫu nhiên
    public void GenerateRandomGraph(int edgeCount)
    {
        Random random = new Random();
        int addedEdges = 0;
        
        while (addedEdges < edgeCount)
        {
            int v = random.Next(V);
            int w = random.Next(V);
            
            if (v != w && !adj[v].Contains(w))
            {
                AddEdge(v, w);
                addedEdges++;
            }
        }
    }
}
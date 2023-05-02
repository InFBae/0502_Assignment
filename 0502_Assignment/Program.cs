namespace _0502_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int INF = 99999;
            int[,] graph = new int[,]
                {
                    { 0 , 2 ,INF,INF, 9 ,INF,INF,INF},
                    { 2 , 0 ,INF, 8 ,INF,INF, 5 ,INF},
                    {INF,INF, 0 ,INF,INF,INF, 7 ,INF},
                    {INF, 8 ,INF, 0 ,INF,INF,INF,INF},
                    { 9 ,INF,INF,INF, 0 ,INF, 9 , 5 },
                    {INF,INF,INF,INF,INF, 0 , 6 ,INF},
                    {INF, 5 , 7 ,INF, 9 , 6 , 0 ,INF},
                    {INF,INF,INF,INF, 5 ,INF,INF, 0 }
                };

            Dijkstra dijkstra = new Dijkstra();
            int size = graph.GetLength(0);
            int[] cost = new int[size];
            int[] path = new int[size];
            dijkstra.ShortestPath(0, graph, out cost, out path);

            Console.WriteLine("Result: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Vertex : {i}\tCost : {cost[i]}\tPath : {path[i]}");
            }

        }
    }
}
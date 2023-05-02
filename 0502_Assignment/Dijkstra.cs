using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0502_Assignment
{
    internal class Dijkstra
    {
        public void ShortestPath(int start, int[,] graph, out int[] cost, out int[] path)
        {
            const int INF = 99999;
            int vertex = graph.GetLength(0);
            bool[] known = new bool[vertex];
            cost = new int[vertex];
            path = new int[vertex];

            for (int i = 0; i < vertex; i++)
            {
                known[i] = false;
                cost[i] = graph[start, i];
                path[i] = graph[start, i] < INF ? start : -1;                
            }
            
            path[start] = -1;
            // 모든 정점을 검사 
            for(int i = 0; i < vertex; i++)
            {   
                int next = -1;
                int minCost = INF;
                // 방문하지 않았으면서 가장 가까운 정점 찾기
                for (int j = 0; j < vertex; j++)
                {                    
                    if (!known[j] && cost[j] < minCost)
                    {
                        next = j;
                        minCost = cost[j];
                    }
                }
                if (next < 0) break;
                // j에 가장 가까운 거리 탐색  middle = next        
                for(int j = 0; j < vertex; j++)
                {
                    if (cost[j] > cost[next] + graph[next, j])
                    {
                        cost[j] = cost[next] + graph[next, j];
                        path[j] = next;
                    }
                }
                known[next] = true;
            }            
        }
    }
}

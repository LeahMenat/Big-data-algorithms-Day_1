using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Edge
    {
        public int From { get; set; }
        public int To { get; set; }
        public Edge(int from, int to)
        {
            this.From = from;
            this.To = to;
        }
    }
    public class Vertice
    {
        public int Name { get; set; }
        public bool IsVisited { get; set; }
        public List<int> Adjacency { get; set; }

        public Vertice(int name, bool visited)
        {
            this.Name = name;
            this.IsVisited = visited;
            this.Adjacency = new List<int>();
        }
        public void addAdjacency(int adj)
        {
            this.Adjacency.Add(adj);
        }
    }
    public static class Graph
    {
        public static Dictionary<int, Vertice> ArrayOfAdjacencyList(Edge[] edgesArr)
        {
            Dictionary<int, Vertice> d = new Dictionary<int, Vertice>();
            for (int i = 0; i < edgesArr.Length; i++)
            {
                if (!d.ContainsKey(edgesArr[i].From))
                    d.Add(edgesArr[i].From, new Vertice(edgesArr[i].From, false));
                if (!d.ContainsKey(edgesArr[i].To))
                    d.Add(edgesArr[i].To, new Vertice(edgesArr[i].To, false));
                d[edgesArr[i].From].addAdjacency(edgesArr[i].To);
                d[edgesArr[i].To].addAdjacency(edgesArr[i].From);
            }
            return d;
        }
        public static int DFS(Dictionary<int, Vertice> d)
        {
            int cc = 0;
            foreach (var item in d)
            {
                if (!item.Value.IsVisited)
                {
                    Explore(item.Value, d);
                    cc++;
                }
            }
            return cc;
        }

        public static void Explore(Vertice v, Dictionary<int, Vertice> d)
        {
            v.IsVisited = true;
            foreach (int adj in v.Adjacency)
            {
                if (!d[adj].IsVisited)
                    Explore(d[adj], d);
            }
        }

        public static int CountNumberOfTreesInAForest(Edge[] edgesArr)
        {
            Dictionary<int, Vertice> d = ArrayOfAdjacencyList(edgesArr);
            return DFS(d);
        }

        public static List<int> SteppingNumber(int start, int end)
        {
            int[] arrDefault = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> lAns = new List<int>();
            Queue<int> q = new Queue<int>(arrDefault);
            while (q.Count != 0)
            {
                int step = q.Dequeue();
                if (step >= start)
                {
                    Console.Write(step + ", ");
                    lAns.Add(step);
                }
                int next = step * 10 + step - 1;
                if (next <= end)
                {
                    q.Enqueue(next);
                    next = step * 10 + step + 1;
                    if (next <= end)
                        q.Enqueue(next);
                }
                else
                    while (q.Count != 0)
                        if (q.Peek() >= start)
                        {
                            lAns.Add(q.Peek());
                            Console.Write(q.Dequeue() + ", ");
                        }
                        else
                            q.Dequeue();
            }
            Console.WriteLine();
            return lAns;
        }
    }
}

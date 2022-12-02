//#define USE_MATRIX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CoinFlip
{
    static internal class Program
    {

#if UNDIRECTED
        static bool[,] mGraph = new bool[,]
        {
                   // "TTT"     "TTH"    THT       THH       HTT      HTH        HHT       HHH
         /* TTT */  { false   , true    , true    , false   , true    , false   , false   , false },
         /* TTH */  { true    , false   , false   , true    , false   , false   , false   , false },
         /* THT */  { true    , false   , false   , false   , false   , false   , false   , false },
         /* THH */  { false   , true    , false   , false   , false   , false   , false   , true  },
         /* HTT */  { true    , false   , false   , false   , false   , false   , true    , false },
         /* HTH */  { false   , false   , false   , false   , false   , false   , false   , true  },
         /* HHT */  { false   , false   , false   , false   , true    , false   , false   , true  },
         /* HHH */  { false   , false   , false   , true    , false   , true    , true    , false }
        };


        /// to add cost to the matrix, we can change it to int and use -1 
        /// to indicate nodes are not adjacent (if the costs are only positive)
        static int[,] mGraph = new int[,]
        {
                   // "TTT"     "TTH"    THT       THH       HTT      HTH        HHT       HHH
         /* TTT */  { -1   ,       1    , 2 ...
        };


        /// the cost can be added using tuples (neighbor,cost)
        static int[][] lGraph = new int[][]
        {
            /* TTT */ new int[] {(1,1), (2,2), (4,4) },
            /* TTH */ new int[] { (0,1), (3,3) },
            /* THT */ new int[] { 0 },
            /* THH */ new int[] { 1, 7 },
            /* HTT */ new int[] { 0, 6 },
            /* HTH */ new int[] { 7 },
            /* HHT */ new int[] { 4, 7 },
            /* HHH */ new int[] { 3, 5, 6 }
        };

        /// or defining a parallel cost adjacency list
        static int[][] lCost = new int[][]
        {
            /* TTT */ new int[] {1, 2, 4 },
            /* TTH */ new int[] { 5, 3},
            /* THT */ new int[] { 0 },
            /* THH */ new int[] { 1, 7 },
            /* HTT */ new int[] { 0, 6 },
            /* HTH */ new int[] { 7 },
            /* HHT */ new int[] { 4, 7 },
            /* HHH */ new int[] { 3, 5, 6 }
        };
#else
        // the adjacency values for the directed graph version.  
        // Only allow the paths that reach the goal
        static bool[,] mGraph = new bool[,]
        {
           { false   , true    , false   , false   , true    , false   , false   , false },
           { false   , false   , false   , true    , false   , false   , false   , false },
           { true    , false   , false   , false   , false   , false   , false   , false },
           { false   , false   , false   , false   , false   , false   , false   , true },
           { false   , false   , false   , false   , false   , false   , true    , false },
           { false   , false   , false   , false   , false   , false   , false   , false },
           { false   , false   , false   , false   , false   , false   , false   , true },
           { false   , false   , false   , false   , false   , true    , false   , false }
        };

        static int[][] lGraph = new int[][]
        {
            new int[] { 1, 4 },
            new int[] { 3 },
            new int[] { 0 },
            new int[] { 7 },
            new int[] { 6 },
            null,
            new int[] { 7 },
            new int[] { 5 }
        };
#endif

        static int nState = 0;
        static string sUserState;

        static bool bWaitingForMove = false;

        static Object lockObject = new Object();

        static List<Node> game = new List<Node>();


        static void Main(string[] args)
        {
            Random rand = new Random();
            Node node;

            // populate the game List<Node> to calculate the shortest path from 2 to 5
            node = new Node(0);
            game.Add(node);

            node = new Node(1);
            game.Add(node);

            node = new Node(2);
            game.Add(node);

            node = new Node(3);
            game.Add(node);

            node = new Node(4);
            game.Add(node);

            node = new Node(5);
            game.Add(node);

            node = new Node(6);
            game.Add(node);

            node = new Node(7);
            game.Add(node);

            game[0].AddEdge(1, game[1]);
            game[0].AddEdge(2, game[2]);
            game[0].AddEdge(4, game[4]);
            game[0].edges.Sort();

            game[1].AddEdge(1, game[0]);
            game[1].AddEdge(3, game[3]);
            game[1].edges.Sort();

            game[2].AddEdge(2, game[0]);
            game[2].edges.Sort();

            game[3].AddEdge(3, game[1]);
            game[3].AddEdge(7, game[7]);
            game[3].edges.Sort();

            game[4].AddEdge(4, game[0]);
            game[4].AddEdge(6, game[6]);
            game[4].edges.Sort();

            game[5].AddEdge(7, game[7]);
            game[5].edges.Sort();

            game[6].AddEdge(6, game[4]);
            game[6].AddEdge(7, game[7]);
            game[6].edges.Sort();

            game[7].AddEdge(7, game[3]);
            game[7].AddEdge(7, game[5]);
            game[7].AddEdge(7, game[6]);
            game[7].edges.Sort();

            // get the shortest path
            List<Node> shortestPath = GetShortestPathDijkstra();


            // the current string representation of the coin state
            string sState;

            // the user-entered numeric representation of the desired coin state
            int nUserState;

            int nMoves = 0;

            nState = 2;

            while (true)
            {
                nState = rand.Next(0, 8);

                if (nState != 5)
                {
                    break;
                }
            }

            Thread t = new Thread(DFS);
            t.Start();

            while (nState != 5)
            {
                // convert the current numeric state to a string
                sState = NState2SState(nState);

                // output the current state
                Console.WriteLine("Current coin state: " + sState);

                // prompt for the desired state
                Console.Write("Enter the desired state: ");
                //sUserState = Console.ReadLine().ToUpper();

                lock (lockObject)
                {
                    bWaitingForMove = true;
                }

                while (bWaitingForMove) ;

                nUserState = SState2NState(sUserState);
                Console.WriteLine(sUserState);

#if USE_MATRIX
                if (mGraph[nState, nUserState])
                {
                    nState = nUserState;
                    ++nMoves;
                }
                else
                {
                    Console.WriteLine("That is an invalid move.");
                }
#else

                int[] thisStateList = lGraph[nState];
                bool bValid = false;

                if (thisStateList != null)
                {
                    foreach (int n in thisStateList)
                    {
                        if (n == nUserState)
                        {
                            bValid = true;
                            nState = nUserState;
                            ++nMoves;
                            break;
                        }
                    }
                }

                if (!bValid)
                {
                    Console.WriteLine("That is an invalid move.");
                }
#endif
            }

            Console.WriteLine($"You won in {nMoves} moves!");
            t.Abort();
        }


        // convert the string to the equivalent 2-based integer
        static int SState2NState(string sState)
        {
            int nState = 0;

            // HHT should be converted to 6
            for (int i = 0; i < 3; ++i)
            {
                if (sState[i] == 'H')
                {
                    nState += (1 << (2 - i));
                }
            }

            return (nState);
        }

        // convert the 2-based integer to the equivalent string
        static string NState2SState(int nState)
        {
            string r = null;

            // 6 should be HHT
            for (int i = 0; i < 3; ++i)
            {
                if ((nState & (1 << (2 - i))) != 0)
                {
                    r += "H";
                }
                else
                {
                    r += "T";
                }
            }

            return (r);
        }

        static void DFS()
        {
            bool[] visited = new bool[lGraph.Length];

            DFSUtil(nState, visited);
        }

        static void DFSUtil(int v, bool[] visited)
        {
            while (!bWaitingForMove) ;

            visited[v] = true;

            sUserState = NState2SState(v);

            lock (lockObject)
            {
                bWaitingForMove = false;
            }

            int[] thisStateList = lGraph[v];
            if (thisStateList != null)
            {
                foreach (int n in thisStateList)
                {
                    if (!visited[n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }
        }

        /****************************************************************************************
        The Dijkstra algorithm was discovered in 1959 by Edsger Dijkstra.
        This is how it works:
        
        1. From the start node, add all connected nodes to a priority queue.
        2. Sort the priority queue by lowest cost and make the first node the current node.
           For every child node, select the shortest path to start.
           When all edges have been investigated from a node, that node is "Visited" 
           and you don´t need to go there again.
        3. Add each child node connected to the current node to the priority queue.
        4. Go to step 2 until the queue is empty.
        5. Recursively create a list of each node that defines the shortest path 
           from end to start.
        6. Reverse the list and you have found the shortest path
        
        In other words, recursively for every child of a node, measure its distance to the start. 
        Store the distance and what node led to the shortest path to start. When you reach the end 
        node, recursively go back to the start the shortest way, reverse that list and you have the 
        shortest path.
        ******************************************************************************************/

        static public List<Node> GetShortestPathDijkstra()
        {
            DijkstraSearch();
            List<Node> shortestPath = new List<Node>();
            shortestPath.Add(game[5]);
            BuildShortestPath(shortestPath, game[5]);
            shortestPath.Reverse();
            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }


        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = game[2];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            //Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            Func<Node, int> nodeOrderBy = NodeOrderBy;

            do
            {
                // sort our prioQueue by minCostToStart
                // option #1, use .Sort() which sorts in place
                prioQueue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // the next 6 lines are equivalent from descriptive to abbreviated:
                prioQueue = prioQueue.OrderBy(nodeOrderBy).ToList();
                prioQueue = prioQueue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => n.minCostToStart).ToList();
                prioQueue = prioQueue.OrderBy(n => n.minCostToStart).ToList();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in //node.edges)
                         node.edges.OrderBy(delegate (Edge n) { return n.cost; }))
                {
                    Node childNode = cnn.connectedNode;
                    if (childNode.visited)
                    {
                        continue;
                    }

                    if (childNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < childNode.minCostToStart)
                    {
                        childNode.minCostToStart = node.minCostToStart + cnn.cost;
                        childNode.nearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                        {
                            prioQueue.Add(childNode);
                        }
                    }
                }

                node.visited = true;

                // if we reeached our target
                if (node == game[5])
                {
                    return;
                }
            } while (prioQueue.Any());
        }
    }

    public class Node : IComparable<Node>
    {
        // data
        public int nState;

        // list of edges
        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(int nState)
        {
            this.nState = nState;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }

}

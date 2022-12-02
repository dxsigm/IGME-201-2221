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


        static int[][] lGraph = new int[][]
        {
            /* TTT */ new int[] {1, 2, 4 },
            /* TTH */ new int[] { 0, 3 },
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


        static void Main(string[] args)
        {
            Random rand = new Random();

            // the current string representation of the coin state
            string sState;

            // the user-entered numeric representation of the desired coin state
            int nUserState;

            int nMoves = 0;

            nState = 2;

            while(true)
            {
                nState = rand.Next(0, 8);

                if( nState != 5 )
                {
                    break;
                }
            }

            Thread t = new Thread(DFS);
            t.Start();

            while( nState != 5)
            {
                // convert the current numeric state to a string
                sState = NState2SState(nState);

                // output the current state
                Console.WriteLine("Current coin state: " + sState);

                // prompt for the desired state
                Console.Write("Enter the desired state: ");
                //sUserState = Console.ReadLine().ToUpper();

                lock(lockObject)
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

                if( thisStateList != null )
                {
                    foreach(int n in thisStateList)
                    {
                        if( n == nUserState)
                        {
                            bValid = true;
                            nState = nUserState;
                            ++nMoves;
                            break;
                        }
                    }
                }

                if( !bValid)
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
    }
}

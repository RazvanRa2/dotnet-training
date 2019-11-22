using System;

namespace lab7___graphs
{

    class Graph
    {
        int nodeCount;
        bool[][] nodes;

        public Graph(int newSize)
        {
            // initialize size as size and nodes as a matrix of newSize x newSize elements
        }

        public void AddEdge(int start, int stop)
        {
            // for the purpose of this exercise, the graph is not oriented.
            // you will need to set both nodes[i][j] and nodes[j][i]

            // do you see any optimization here? think of linkedlists and space optimization
        }

        public void RemoveEdge(int start, int stop)
        {
            // remove edges from start to stop and from stop to start
        }

        public void bfs(int startNode)
        {
            // start from start node
            // create an openList and a closedList
            // the closed list contains the nodes that have been visited
                // a node has been visited when all its neighbours have been added to the openList
            // the openList contain the frontier = the nodes that we marked to be visited
            // add the startNode to the openlist

            // while there are nodes in the openList
                // remove the first element from the openList
                // print its position
                // iterate through the neighbours of that node
                // if those node weren't visited before (meaning they're not in the closed list)
                    // add them to the openList at the back
                // mark the curentnode (the one removed in this iteration) as visited (add it to the closed list)

            // UNDERSTANDING THE ALGORITHM:
            // imagine you are Napoleon, trying to conquer Europe.
            // the closed list is your teritory - France.
            // the closed list is your frontier.
            // you move from a start node - say Paris and look for neighbouring cities.
            // you add all the cities that weren't already part of France to your conquest's frontier
            // you then check all of the cities in the frontier and one by one, you conquer them
            // then, you look again at your new frontier, that was pushed further back. and start again.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);
            graph.AddEdge(3,4);
            graph.AddEdge(1,2);
            graph.AddEdge(0,1);
            graph.AddEdge(2,2);
            graph.AddEdge(2,3);
            graph.AddEdge(1,4);
            graph.AddEdge(3,3);

            graph.RemoveEdge(3,3);

            graph.bfs(0);
        }
    }
}

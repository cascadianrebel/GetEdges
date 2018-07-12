using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges
{
    public class AdjacencyList
    {
        public Dictionary<Node, int> AddNodes(Node node)
        {
            Dictionary<Node, int> edge = new Dictionary<Node, int>();
            edge.Add(node, node.Value);
            return edge;
        }

        public void CreateAdjList(Node node, Dictionary<Node, int> vertices)
        {
            Dictionary<Node, Dictionary<Node, int>> adj = new Dictionary<Node, Dictionary<Node, int>>();
            adj.Add(node, vertices);
        }

    }
}

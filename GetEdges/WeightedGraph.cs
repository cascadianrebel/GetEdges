using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges
{
    class WeightedGraph
    {
        List<Dictionary<Node,int>> Vertices { get; set; }

        public void AddEdge(Node u, Node v)
        {
            int index = Vertices.IndexOf(u);

            Vertices[index].
        }
    }
}

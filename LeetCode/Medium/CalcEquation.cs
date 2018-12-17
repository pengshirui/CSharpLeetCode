using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public double[] CalcEquation(string[,] equations, double[] values, string[,] queries)
        {
            var graph = BuildGraph(equations, values);
            var size = queries.GetLength(0);
            var result = new double[size];
            for (var i = 0; i < size; i++)
            {
                var start = queries[i, 0];
                var end = queries[i, 1];

                var res = Dfs(start, end, graph, 1, new HashSet<string>());
                result[i] = res == 0 ? -1 : res;
            }

            return result;
        }

        private double Dfs(string start, string end, Dictionary<string, Node> graph, double result, HashSet<string> visited)
        {
            if (!graph.ContainsKey(start) || !graph.ContainsKey(end) || result == 0 || visited.Contains(start))
            {
                return 0;
            }

            if (start == end)
            {
                return result;
            }
            
            visited.Add(start);

            var tmp = 0.0;
            if (graph.TryGetValue(start, out var startNode))
            {
                foreach(var pair in startNode.Nodes)
                {
                    tmp = Dfs(pair.Key.Value, end, graph, result * pair.Value, visited);
                    if (tmp != 0)
                    {
                        break;
                    }
                }
            }

            // Stack removed visited node
            visited.Remove(start);

            return tmp;
        }

        private Dictionary<string, Node> BuildGraph(string[,] equations, double[] values)
        {
            var graph = new Dictionary<string, Node>();
            for (var i = 0; i < equations.GetLength(0); i++)
            {
                var left = equations[i, 0];
                var right = equations[i, 1];

                if (graph.TryGetValue(right, out var rightNode))
                {
                    // Leave blank
                }
                else
                {
                    // create this new node
                    rightNode = new Node(right);
                    graph.Add(right, rightNode);
                }

                if (graph.TryGetValue(left, out var leftNode))
                {
                    
                }
                else
                {
                    leftNode = new Node(left);
                    graph.Add(left, leftNode);
                }

                leftNode.Nodes.Add(rightNode, values[i]);
                rightNode.Nodes.Add(leftNode, 1 / values[i]);
            }

            return graph;
        }
    }

    class Node
    {
        public string Value { get; set; }

        public readonly Dictionary<Node, double> Nodes;

        public Node(string value)
        {
            this.Value = value;
            this.Nodes = new Dictionary<Node, double>();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

using GraphVizWrapper;
using GraphVizWrapper.Commands;
using GraphVizWrapper.Queries;
using Minty.Model;

namespace Minty.Util
{
    class GraphVisualizer
    {

        public string generateDotFileForGraph(Graph graph)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("digraph g {");
            
            foreach (Edge edge in graph.Edges)
            {
                stringBuilder.Append(edge.Source.Id + "->" + edge.Destination.Id + "[label=" + 
                    edge.Weight + "];");
            }
            string result = stringBuilder.ToString().TrimEnd('-', '>');
            stringBuilder.Append("}");

            return stringBuilder.ToString();
        }

        public void generateGraphBitmap()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            try {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                baseDirectory = baseDirectory.Substring(0, baseDirectory.LastIndexOf('\\')); // +

                process.StartInfo.WorkingDirectory = baseDirectory;
                process.StartInfo.FileName = "task.bat";
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
            } catch (Exception ex) {
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        } 
    }
}

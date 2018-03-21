using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Minty.Model;
using Newtonsoft.Json;

namespace Minty.Util
{
    /// <summary>
    /// Class FileSystemManager is a utility class that is in charge of input/output
    /// operations with the computer's file system.
    /// This class contains methods that allow the application save and read a graph object.
    /// FileSystemManager class was des
    /// </summary>
    sealed class FileSystemManager
    {
        public static void saveGraphToFile(Graph graph, String fileName) {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(graph));
        }

        public static Graph readGraphFromFile(String fileName)
        {
            using (StreamReader file = File.OpenText(fileName)) {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<Graph>(json);
            }
        }

        public static void saveGraphDotTemplateToFile(String dotFile) {
            string templatePath = @"D:\Progs\C#\2018\Minty\Minty\data\template.dt";
            File.WriteAllText(templatePath, dotFile);
        }
    }
}

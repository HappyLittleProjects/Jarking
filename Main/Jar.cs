using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Jar
    {
        // keeps track of all jars that are created [ should be put into db ]
        private static Dictionary<string, Jar> jar = new Dictionary<string, Jar>();

        public string name;             // name of jar
        public string description;      // kinds of thoughts in the jar

        private string id;              // jar's id
        
        // thought storage
        private List<string> thought = new List<string>();

        /// <summary>
        /// Create a jar; Defines name and description and creates id for the jar.
        /// </summary>
        /// <param name="name"></param> Name of jar
        /// <param name="description"></param>  Describe what jar is for
        public Jar(string name, string description = "") 
        { 
            this.name = name;
            this.description = description;
            this.id = $"{name}{jar.Count}";
            jar.Add(this.id, this );
        }

        /// <summary>
        /// Add thought to the jar
        /// </summary>
        /// <param name="thought"></param>
        public void Add(string thought)
        {
            this.thought.Add(thought);
        }

        /// <summary>
        /// Returns a random string that is stored in the thoughts list.
        /// </summary>
        /// <returns></returns>
        public string Pull()
        {
            int num = new Random().Next(0, this.thought.Count);
            return this.thought[num];
        }

        /// <summary>
        /// Returns a jar with the given id. This function is meant for when jars
        /// are shared.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Jar GetJar(string id)
        {
            return jar[id];
        }
    }
}

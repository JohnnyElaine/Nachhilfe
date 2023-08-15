using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab0Angabe
{
    public sealed class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string[] Performers { get; set; }
        public float Rating { get; set; }
        public TimeSpan Duration { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Title} ({Year})";
        }
    }
}

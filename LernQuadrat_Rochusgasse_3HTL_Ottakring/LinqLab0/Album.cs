using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab0Angabe
{
    public sealed class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public List<Song> Songs { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Title} ({Artist}, {Songs.Count} songs)";
        }
    }
}

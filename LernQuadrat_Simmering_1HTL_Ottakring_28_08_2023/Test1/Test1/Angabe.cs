using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Angabe
    {
        const string PATH = "../../../input.txt";
        public static List<string> generateList()
        {
            List<string> list = new List<string>();

            using (StreamReader reader = new StreamReader(PATH))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            return list;
        }
    }
}

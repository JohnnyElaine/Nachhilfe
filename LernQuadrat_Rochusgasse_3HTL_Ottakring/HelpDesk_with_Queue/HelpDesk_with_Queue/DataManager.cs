using HelpRequestLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_with_Queue
{
    static class DataManager
    {

        private const char DELIMITER = ';';

        public static void WriteAllRequests(Queue<HelpRequest> requests, string path)
        {

            List<string> requestStrings = new List<string>();

            foreach (HelpRequest request in requests) requestStrings.Add(request.ToString());
            
            File.WriteAllLines(path, requestStrings);

        }

        public static Queue<HelpRequest> ReadAllRequests(string path)
        {
            Queue<HelpRequest> requests = new Queue<HelpRequest>();

            // Create the file if it doesn't exist
            if (!File.Exists(path)) File.Create(path).Close();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    requests.Enqueue(stringToHelpRequest(line));
                }
            }


            return requests;
        }

        private static HelpRequest stringToHelpRequest(string s)
        {
            string[] sp = s.Split(DELIMITER);

            return new HelpRequest(sp[0], sp[1], DateTime.Parse(sp[2]));
        }
    }
}

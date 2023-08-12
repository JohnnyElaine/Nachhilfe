namespace HelpRequestLibrary
{
    public class HelpRequest
    {
        private const char DELIMITER = ';';
        public string name { get;}
        public string request { get; }
        public DateTime date { get; }

        public HelpRequest(string name, string request, DateTime date) { 

            if (name == null || date == null) throw new ArgumentNullException("name & date must not be null");
            
            this.name = name;
            this.request = request;
            this.date = date;
        }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}{3}{4}", name, DELIMITER, request, DELIMITER, date.ToString());
        }
    }
}
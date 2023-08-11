namespace HelpRequestLibrary
{
    public class HelpRequest
    {
        public string name { get;}
        public string request { get; }
        public DateTime date { get; }

        public HelpRequest(string name, string request, DateTime date) { 

            if (name == null || date == null) throw new ArgumentNullException("name & date must not be null");
            
            this.name = name;
            this.request = request;
            this.date = date;
        }


    }
}
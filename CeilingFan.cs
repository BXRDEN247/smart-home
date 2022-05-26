namespace RemoteControl
{
    public class CeilingFan
    {
        private string _location;
        public static string bathroom;
        public static string bedroom;
        public static string kitchen;
        public static string livingroom;

        public CeilingFan(string location)
        {
            _location = location;
            bathroom = "Off";
            bedroom = "Off";
            kitchen = "Off";
            livingroom = "Off";
        }

        public string SetHigh(string location)
        {
            
            return $"{location} ceiling fan is on\n";
        }

    
        public string Off(string location)
        {
            return $"{location} ceiling fan is off\n";
        }

    }
}

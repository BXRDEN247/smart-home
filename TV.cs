namespace RemoteControl
{
    public class TV
    {
        private string _location;
        public static string bathroom;
        public static string bedroom;
        public static string kitchen;
        public static string livingroom;    
        public TV(string location)
        {
            _location = location;
            bathroom = "Off";
            bedroom = "Off";
            kitchen = "Off";
            livingroom = "Off";
        }

        public string Start(string location)
        {
            return $"{location} TV is started\n";
        }

        public string Stop(string location)
        {
            return $"{location} TV is stopped\n";
        }
    }
}

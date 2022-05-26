
namespace RemoteControl
{
    
    public class Light
    {   
        private string _location = "null";
        public static string bathroom;
        public static string bedroom;
        public static string kitchen;
        public static string livingroom;
        


        public Light(string location)
        {
            _location = location;
            bathroom = "Off";
            bedroom = "Off";
            kitchen = "Off";
            livingroom = "Off";
        }


        public string On(string location)
        {
            return $"{location} light is on\n";

        }

        public string Off(string location)
        {
            return $"{location} light is off\n";
        }
    }
}

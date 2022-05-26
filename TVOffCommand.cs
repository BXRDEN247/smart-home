namespace RemoteControl
{
    public class TVOffCommand : ICommand
    {
        private TV _tv;

        public TVOffCommand(string location)
        {
            _tv = new TV(location);
        }

        public string Execute(string location)
        {
            if (location == "Bathroom")
            {
                if (TV.bathroom == "Off")
                {
                    return "Start the TV first\n";
                }
                TV.bathroom = "Off";
            }

            if (location == "Bedroom")
            {
                if (TV.bedroom == "Off")
                {
                    return "Start the TV first\n";
                }
                TV.bedroom = "Off";
            }

            if (location == "Kitchen")
            {
                if (TV.kitchen == "Off")
                {
                    return "Start the TV first\n";
                }
                TV.kitchen = "Off";
            }

            if (location == "Living Room")
            {
                if (TV.livingroom == "Off")
                {
                    return "Start the TV first\n";
                }
                TV.livingroom = "Off";
            }
            return _tv.Stop(location);
        }

        public string GetName()
        {
            return "TV OFF";
        }
    }

    // in mod similar trebuie create obiecte de comanda pentru LightOff, CeilingFanOff, CeilingFanOn, TVOff si TVOn
}

namespace RemoteControl
{
    public class TVOnCommand : ICommand
    {
        private TV _tv;

        public TVOnCommand(string location)
        {
            _tv = new TV(location);
        }

        public string Execute(string location)
        {
            if (location == "Bathroom")
            {
                if (TV.bathroom == "On")
                {
                    return "The TV is already running here\n";
                }
                TV.bathroom = "On";
            }

            if (location == "Bedroom")
            {
                if (TV.bedroom == "On")
                {
                    return "The TV is already running here\n";
                }
                TV.bedroom = "On";
            }

            if (location == "Kitchen")
            {
                if (TV.kitchen == "On")
                {
                    return "The TV is already running here\n";
                }
                TV.kitchen = "On";
            }

            if (location == "Living Room")
            {
                if (TV.livingroom == "On")
                {
                    return "The TV is already running here\n";
                }
                TV.livingroom = "On";
            }
            return _tv.Start(location);
        }

        public string GetName()
        {
            return "TV ON";
        }
    }

    // in mod similar trebuie create obiecte de comanda pentru LightOff, CeilingFanOff, CeilingFanOn, TVOff si TVOn
}

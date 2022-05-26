namespace RemoteControl
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanOffCommand(string location)
        {
            _ceilingFan = new CeilingFan(location);
        }

        public string Execute(string location)
        {
            if (location == "Bathroom")
            {
                if (CeilingFan.bathroom == "Off")
                {
                    return "Turn the ceiling fan on first\n";
                }
                CeilingFan.bathroom = "Off";
            }

            if (location == "Bedroom")
            {
                if (CeilingFan.bedroom == "Off")
                {
                    return "Turn the ceiling fan on first\n";
                }
                CeilingFan.bedroom = "Off";
            }

            if (location == "Kitchen")
            {
                if (CeilingFan.kitchen == "Off")
                {
                    return "Turn the ceiling fan on first\n";
                }
                CeilingFan.kitchen = "Off";
            }

            if (location == "Living Room")
            {
                if (CeilingFan.livingroom == "Off")
                {
                    return "Turn the ceiling fan on first\n";
                }
                CeilingFan.livingroom = "Off";
            }
            return _ceilingFan.Off(location);
        }

        public string GetName()
        {
            return "Ceiling fan OFF";
        }
    }

    // in mod similar trebuie create obiecte de comanda pentru LightOff, CeilingFanOff, CeilingFanOn, TVOff si TVOn
}

namespace RemoteControl
{
    public class CeilingFanOnCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanOnCommand(string location)
        {
            _ceilingFan = new CeilingFan(location);
        }

        public string Execute(string location)
        {

            if (location == "Bathroom")
            {
                if (CeilingFan.bathroom == "On")
                {
                    return "The ceiling fan is already turned on here\n";
                }
                CeilingFan.bathroom = "On";
            }

            if (location == "Bedroom")
            {
                if (CeilingFan.bedroom == "On")
                {
                    return "The ceiling fan is already turned on here\n";
                }
                CeilingFan.bedroom = "On";
            }

            if (location == "Kitchen")
            {
                if (CeilingFan.kitchen == "On")
                {
                    return "The ceiling fan is already turned on here\n";
                }
                CeilingFan.kitchen = "On";
            }

            if (location == "Living Room")
            {
                if (CeilingFan.livingroom == "On")
                {
                    return "The ceiling fan is already turned on here\n";
                }
                CeilingFan.livingroom = "On";
            }
            return _ceilingFan.SetHigh(location);
        }

        public string GetName()
        {
            return "Ceiling fan ON";
        }
    }

    // in mod similar trebuie create obiecte de comanda pentru LightOff, CeilingFanOff, CeilingFanOn, TVOff si TVOn
}

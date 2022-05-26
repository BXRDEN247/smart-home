using System;

namespace RemoteControl
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(string location)
        {
            _light = new Light(location);
        }

        public string Execute(string location)
        {
            if (location == "Bathroom")
            {
                if (Light.bathroom == "On")
                {
                    return "The light is already turned on here\n";
                }
                Light.bathroom = "On";
            }

            if (location == "Bedroom")
            {
                if (Light.bedroom == "On")
                {
                    return "The light is already turned on here\n";
                }
                Light.bedroom = "On";
            }

            if (location == "Kitchen")
            {
                if (Light.kitchen == "On")
                {
                    return "The light is already turned on here\n";
                }
                Light.kitchen = "On";
            }

            if (location == "Living Room")
            {
                if (Light.livingroom == "On")
                {
                    return "The light is already turned on here\n";
                }
                Light.livingroom = "On";
            }
            return _light.On(location);
        }

        public string GetName()
        {
            return "Light ON";
        }
    }

    // in mod similar trebuie create obiecte de comanda pentru LightOff, CeilingFanOff, CeilingFanOn, TVOff si TVOn
}

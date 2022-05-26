using System;

namespace RemoteControl
{
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(string location)
        {

            _light = new Light(location);
        }

        public string Execute(string location)
        {
            if (location == "Bathroom")
            {
                if (Light.bathroom == "Off")
                {
                    return "Turn the light on first\n";
                }
                Light.bathroom = "Off";
            }

            if (location == "Bedroom")
            {
                if (Light.bedroom == "Off")
                {
                    return "Turn the light on first\n";
                }
                Light.bedroom = "Off";
            }

            if (location == "Kitchen")
            {
                if (Light.kitchen == "Off")
                {
                    return "Turn the light on first\n";
                }
                Light.kitchen = "Off";
            }

            if (location == "Living Room")
            {
                if (Light.livingroom == "Off")
                {
                    return "Turn the light on first\n";
                }
                Light.livingroom = "Off";
            }
            return _light.Off(location);
        }

        public string GetName()
        {
            return "Light OFF";
        }
    }
}
namespace RemoteControl
{
    public class NoCommand : ICommand
    {
        // acesta este un "obiect nul" folosit pentru initializarea comenzilor dar care nu face de fapt nimic,
        // insa evita initializarea cu null, care poate cauza exceptii

        public string Execute(string location)
        {
            return "<<no command>>";
        }

        public string GetName()
        {
            return "<<no command>>";
        }
    }
}

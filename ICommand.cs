namespace RemoteControl
{
    public interface ICommand
    {

        string Execute(string location);

        string GetName();
    }
}

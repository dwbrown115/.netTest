namespace GameServer.Services;

public interface IPlayerService
{
    void DoSomething();
}

public class PlayerService : IPlayerService
{
    public void DoSomething()
    {
        Console.WriteLine("Hello");
    }
}

namespace Task3;

public class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;

    public void ScoreGoal()
    {
        System.Console.WriteLine($"Player {Name} score a goal.");
    }

    public void AssistGoal()
    {
        System.Console.WriteLine($"Plaer {Name} assist a goal for Neymar.");
    }

    public string GetInfo()
    {
        return $"Name: {Name}\nNumber: {Team}\nTeam: {Team}\n{Name} scores a goal!\n{AssistGoal}";
    }
}

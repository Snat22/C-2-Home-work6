namespace Task2;

public class Post
{
    public string Text;
    public int Like;
    public List<string> Comments;

    public void SetPost(string text)
    {
        Text = text;
    }
    public void AddLike()
    {
        Like++;
    }

    public void AddComment(string comment)
    {
    
    }

    public string GetInfo()
    {
        return $"{Text}\n{Like}\n{Comments}";
    }
}

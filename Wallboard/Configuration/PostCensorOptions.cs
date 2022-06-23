namespace Wallboard.Configuration;

public class PostCensorOptions
{
    public List<string> BannedWords { get; set; }
    public string Replacement { get; set; }
}
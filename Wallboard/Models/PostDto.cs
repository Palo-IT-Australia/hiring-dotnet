namespace Wallboard.Models;

public class PostDto
{
    public string Name { get; set; }
    public string Content { get; set; }

    public PostDto() { }

    public PostDto(Post post)
    {
        Name = post.Name;
        Content = post.Content;
    }
}
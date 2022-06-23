using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wallboard.Models;

public class Post
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }

    public Post() { }

    public Post(PostDto postDto)
    {
        Name = postDto.Name;
        Content = postDto.Content;
    }
}
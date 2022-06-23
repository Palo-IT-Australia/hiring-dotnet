using Microsoft.Extensions.Options;
using Wallboard.Configuration;
using Wallboard.Models;

namespace Wallboard.Services;

public class PostCensorService: IPostCensorService
{
    private readonly PostCensorOptions _postCensorOptions;

    public PostCensorService(IOptions<PostCensorOptions> postCensorOptions)
    {
        _postCensorOptions = postCensorOptions.Value;
    }
    /// <inheritdoc/>
    public Post CensorPost(Post post)
    {
        foreach (var bannedWord in _postCensorOptions.BannedWords)
        {
            post.Content = post.Content.Replace(bannedWord, _postCensorOptions.Replacement);
            post.Name = post.Name.Replace(bannedWord, _postCensorOptions.Replacement);
        }
        return post;
    }
}
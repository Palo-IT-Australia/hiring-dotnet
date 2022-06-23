using Wallboard.Models;

namespace Wallboard.Services;

public interface IPostCensorService
{
    /// <summary>
    /// Censors a post and replaces any banned words with a replacement word.
    /// </summary>
    /// <param name="post">An uncensored post</param>
    /// <returns>A censored post</returns>
    Post CensorPost(Post post);
}
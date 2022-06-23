using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wallboard.Models;
using Wallboard.Services;

namespace Wallboard.Controllers;

[ApiController]
[Route("/api/wallboard")]
public class WallboardController : Controller
{
    private readonly IDbContextFactory<WallboardContext> _dbContextFactory;

    public WallboardController(IDbContextFactory<WallboardContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }
    
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreatePost(PostDto post)
    {
        var dbContext = await _dbContextFactory.CreateDbContextAsync();
        dbContext.Posts.Add(new Post(post));
        await dbContext.SaveChangesAsync();
        return Ok(post);
    }

    [HttpGet]
    [Route("posts")]
    public async Task<IActionResult> GetPosts()
    {
        var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var posts = await dbContext.Posts.Select(x => new PostDto(x)).ToListAsync();
        return Ok(posts);
    }
}
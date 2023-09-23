using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalWebsite.Utilities;

public class BlogViewModel : PageModel
{
    private readonly BloggingContext _ctx;
    public IEnumerable<Post>? posts { get; set; }
    public BlogViewModel(BloggingContext context)
    {
        _ctx = context;
    }

    public void OnGet()
    {
        //populate the posts list
        posts = _ctx.Posts;
    }
}
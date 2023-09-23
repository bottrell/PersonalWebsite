namespace PersonalWebsite.Utilities;

public class Post
{
    public int PostId { get; set; }
    public string? Title { get; set; }

    // Content will be a string of markdown that we can convert on the page to html
    public string? Content { get; set; }
    public string? CreatedDate { get; set; } = "September 23, 2023";
}
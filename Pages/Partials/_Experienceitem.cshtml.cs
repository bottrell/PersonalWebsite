using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalWebsite.Pages.Partials;

public class ExperienceItemModel : PageModel
{
    public string? date { get; set; } = "September 2023 - Current";
    public string? content { get; set; } = "content goes here";
    public List<string>? skills { get; set; } = new List<string> { "HTML", "CSS", "JavaScript" };
    public ExperienceItemModel(string? d, string? c)
    {
        this.date = d;
        this.content = c;
    }
}
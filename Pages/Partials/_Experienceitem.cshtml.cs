using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalWebsite.Pages.Partials;

public class ExperienceItemModel : PageModel
{
    public string date { get; set; } = "September 2023 - Current";
    public string content { get; set; } = "content goes here";
    void OnGet()
    {
        //TODO - implement this
    }
}
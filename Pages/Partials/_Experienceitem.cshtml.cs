using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalWebsite.Pages.Partials;

public class ExperienceItemModel : PageModel
{
    public string? Date { get; set; }
    public string? Company { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public List<string> Skills { get; set; } = new List<string> { "HTML", "CSS", "Javascript", "Typescript", "C#", ".NET Core", "asdfasdfasdf" };


    public ExperienceItemModel(string? date = "2023 - Current", string? company = "RDN Labs", List<string>? skills = null,
                                string? title = "Software Engineer", string? description = "content goes here", string? location = "Chicago")
    {
        this.Date = date;
        this.Company = company;
        this.Skills = skills!;
        this.Title = title;
        this.Description = description;
        this.Location = location;
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace task.Pages;

public class FormModel : PageModel
{
  
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Message { get; set; }

}

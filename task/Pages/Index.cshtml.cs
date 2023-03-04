using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace task.Pages;

public class IndexModel : PageModel
{
   public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Message { get; set; }
      public string? Date{ get; set; }
}

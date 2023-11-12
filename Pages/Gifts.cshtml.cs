using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GiftExchange.Pages;

public class GiftsModel : PageModel
{
    private readonly ILogger<GiftsModel> _logger;

    public GiftsModel(ILogger<GiftsModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string Recipient {get; set;} = "";

    public IActionResult OnGet([FromRoute] string? recipient)
    {
        if(String.IsNullOrEmpty(recipient))
        {
            _logger.LogInformation("Gift page recipient is empty.");
            return RedirectToPage("./Index");
        }

        _logger.LogInformation("Gift page recipient: " + recipient);
        Recipient = recipient;

        return Page();
    }
}


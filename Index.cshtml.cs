using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Payment_Mode.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string Name { get; set; }
    [BindProperty]
    public string Phone { get; set; }
    [BindProperty]
    public decimal Amount { get; set; }
    [BindProperty]
    public string Network { get; set; }
    [BindProperty]
    public string Email { get; set; }
    public string PaymentReference { get; set; }
    public string PaystackPublicKey => "pk_test_4d01a533a1d5871e002f727f3e704e038eff8626"; // Replace with your real key

    public void OnGet()
    {

    }

    public IActionResult OnPostPay()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        // Generate a unique reference for the payment
        PaymentReference = Guid.NewGuid().ToString("N");
        return Page();
    }
}
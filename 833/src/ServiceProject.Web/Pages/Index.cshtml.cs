using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ServiceProject.Web.Pages;

public class IndexModel : ServiceProjectPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace TrainingAppAspCore.Pages
{
    //NOT IN USE 
    public class LogoutModel : PageModel
    {
        public async Task<ActionResult> OnGet()
        {

           string scheme =  AzureADB2CDefaults.AuthenticationScheme;
            var authenticated = await HttpContext.AuthenticateAsync(scheme);
            if (!authenticated.Succeeded)
            {
                return Challenge(scheme);
            }

            var options = new AzureADB2COptions();

            var callbackUrl = Url.Page("/Index", pageHandler: null, values: null, protocol: Request.Scheme);
            var result = SignOut(new AuthenticationProperties { RedirectUri = callbackUrl }, scheme);

            return RedirectToPage("Index");

        }
    }
}
 
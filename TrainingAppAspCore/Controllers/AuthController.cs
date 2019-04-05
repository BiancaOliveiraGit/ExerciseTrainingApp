using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAppAspCore.Contollers
{
    public class AuthController : Controller
    {
        [Route("[controller]/Logout")]
        public async Task<ActionResult> Logout()
        {
            string scheme = AzureADB2CDefaults.AuthenticationScheme;

            var authenticated = await HttpContext.AuthenticateAsync(scheme);
            if (authenticated.Succeeded)
            {
                // return Challenge(scheme);
                var options = new AzureADB2COptions();
                //http://localhost:24354
                var callbackUrl = "http://localhost:24354/Index";
              // var callbackUrl = Url.Page("/", pageHandler: null, values: null, protocol: Request.Scheme);
               return  SignOut(new AuthenticationProperties { RedirectUri = callbackUrl }, scheme);
            }
            return RedirectToPage("/Index");
        }
    }
}

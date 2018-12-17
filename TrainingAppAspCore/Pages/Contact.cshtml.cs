using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrainingAppAspCore.Pages
{
    public class ContactModel : PageModel
    {
        public string MessageContact { get; set; }
        public string MessageAbout { get; set; }

        public void OnGet()
        {
            MessageContact = "Need some support please email";
            MessageAbout = "Deadpan Melbourne Hipster writing semi-useful applications";
        }
    }
}

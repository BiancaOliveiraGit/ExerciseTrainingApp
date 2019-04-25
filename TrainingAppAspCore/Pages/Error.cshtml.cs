using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrainingAppAspCore.Pages
{
    public class ErrorModel : PageModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => false;//!string.IsNullOrEmpty(RequestId);
        public string ErrorMessage { get; set; }
        public string CallingPage { get; set; }
       // public int CallingIdForGet { get; set; }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            ErrorMessage = TempData["ErrorMessage"].ToString() ?? string.Empty;
            CallingPage = TempData["CallingPage"].ToString() ?? string.Empty;
           
        }
    }
}

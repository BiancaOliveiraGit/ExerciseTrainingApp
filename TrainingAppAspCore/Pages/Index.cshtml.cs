using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrainingAppAspCore.Pages
{

    public class IndexModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;


        public IndexModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }
       

    }
}

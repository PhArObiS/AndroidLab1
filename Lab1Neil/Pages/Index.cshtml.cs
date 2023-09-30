using Lab1Neil.DataSource;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1Neil.Pages
{
    public class IndexModel : PageModel
    {
        public StudentData dataSource = StudentData.GetInstance();

        public IndexModel()
        {
            
        }

        public void OnGet()
        {


        }
        
        public IActionResult OnPostLogout()
        {
            dataSource.StudentLogged = null;
            return RedirectToPage("Index");
        }
    }
}
using Lab1Neil.DataSource;
using Lab1Neil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1Neil.Pages
{
    public class DeleteModel : PageModel
    {

        public StudentData dataSource = StudentData.GetInstance();

        public Student Student { get; set; }

        public IActionResult OnGet(string id)
        {
            if (dataSource.StudentLogged == null)
            {
                return RedirectToPage("Login", new { Error = "PLEASE LOGIN!!!" });
            }

            Student = dataSource.myList.FirstOrDefault(item => item.StudentNumber == id);
            return Page();
        }

        public IActionResult OnPost(string StudentNumber)
        {
            dataSource.myList.RemoveAll(item => item.StudentNumber == StudentNumber);
            return RedirectToPage("Index");
        }
    }
}

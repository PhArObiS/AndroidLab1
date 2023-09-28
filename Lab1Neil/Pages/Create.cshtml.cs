using Lab1Neil.DataSource;
using Lab1Neil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1Neil.Pages
{
    public class CreateModel : PageModel
    {

        public StudentData dataSource = StudentData.GetInstance();

        public void OnGet()
        {
        }

        public IActionResult OnPost(string StudentNumber, string Email, string Password, string Image, string FullName )
        {
            dataSource.myList.Add(new Student(StudentNumber, FullName, Email, Password, Image));
            return RedirectToPage("Index");
        }
    }
}

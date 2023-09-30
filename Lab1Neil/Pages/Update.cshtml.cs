using Lab1Neil.DataSource;
using Lab1Neil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1PhArOh.Pages
{
    public class UpdateModel : PageModel
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

        public IActionResult OnPost(string StudentNumber, string Email, string Image, string FullName)
        {
            var index = dataSource.myList.FindIndex(item => item.StudentNumber == StudentNumber);
            dataSource.myList[index].Email = Email;
            dataSource.myList[index].Image = Image;
            dataSource.myList[index].FullName = FullName;

            return RedirectToPage("Index");
        }

        public IActionResult OnPostLogout()
        {
            dataSource.StudentLogged = null;
            return RedirectToPage("Index");
        }
    }

}


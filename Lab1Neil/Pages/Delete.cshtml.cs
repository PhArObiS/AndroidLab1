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

        public void OnGet(string id)
        {
            Student = dataSource.myList.FirstOrDefault(item => item.StudentNumber == id);
        }

        public IActionResult OnPost(string StudentNumber)
        {
            dataSource.myList.RemoveAll(item => item.StudentNumber == StudentNumber);
            return RedirectToPage("Index");
        }
    }
}

using Lab1Neil.DataSource;
using Lab1Neil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1PhArOh.Pages
{
    public class LoginModel : PageModel
    {
        public StudentData dataSource = StudentData.GetInstance();
        public Student Student { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet(string Error)
        {
            if(Error != null)
            {
                ErrorMessage = Error;
            }
        }

        public IActionResult OnPost(string StudentNumber, string Password)
        {
            Student = dataSource.myList.FirstOrDefault(item => item.StudentNumber == StudentNumber);


            if(Student == null)
            {
                return RedirectToPage("Login", new { Error = "INVALID STUDENT NUMBER!!!" });
            }

            if (Student.CheckPassword(Password)) 
            {
                dataSource.StudentLogged = Student;
                return RedirectToPage("Index");
            }

            return RedirectToPage("Login", new { Error = "INVALLID PASSWORD!!!" });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DeleteModel : PageModel
    {
        private readonly IStudentData studentData;

        public Student Student { get; set; }

        public DeleteModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }

        public IActionResult OnGet(int studentId)
        {
            Student = studentData.GetById(studentId);
            if(Student == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(int studentId)
        {
            var student = studentData.Delete(studentId);
           studentData.Commit();

            if(student == null)
            {
                return RedirectToPage("./NotFound");
            }

            TempData["Message"] = $"{student.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}
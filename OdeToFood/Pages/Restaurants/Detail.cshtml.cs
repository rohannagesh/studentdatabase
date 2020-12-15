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
    public class DetailModel : PageModel
    {
        private readonly IStudentData studentData;

        [TempData]
        public string Message { get; set; }

        public Student Student { get; set; }

        public DetailModel(IStudentData studentData)
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IStudentData studentData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Student Student { get; set; }
        public IEnumerable<SelectListItem> Quotas { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }

        public EditModel(IStudentData studentData,
                         IHtmlHelper htmlHelper)
        {
            this.studentData = studentData;
            this.htmlHelper = htmlHelper;
        }
      
        public IActionResult OnGet(int? studentId)
        {
            Quotas = htmlHelper.GetEnumSelectList<Quota>();
            Departments = htmlHelper.GetEnumSelectList<Department>();
            if (studentId.HasValue)
            {
                Student = studentData.GetById(studentId.Value);
            }
            else
            {
                Student = new Student();
            }
            if(Student == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {               
            if(!ModelState.IsValid)
            {
                Quotas = htmlHelper.GetEnumSelectList<Quota>();
                Departments = htmlHelper.GetEnumSelectList<Department>();
                return Page();                
            }

            if (Student.Id > 0)
            {
                studentData.Update(Student);
            }
            else
            {
                studentData.Add(Student);
            }
            studentData.Commit();
            TempData["Message"] = "Student saved!";
            return RedirectToPage("./Detail", new { studentId = Student.Id });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewComponents
{
    public class StudentCountViewComponent
         : ViewComponent
    {
        private readonly IStudentData studentData;

        public StudentCountViewComponent(IStudentData studentData)
        {
            this.studentData = studentData;
        }

        public IViewComponentResult Invoke()
        {
            var count = studentData.GetCountOfStudents();
            return View(count);
        }

    }
}

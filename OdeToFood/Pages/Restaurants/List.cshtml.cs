using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IStudentData studentData;

        public string Message { get; set; }
        public IEnumerable<Student> Students { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, 
                         IStudentData studentData)
        {
            this.config = config;
            this.studentData = studentData;
        }

        public void OnGet()
        {
            Message = config["Message"];
            Students = studentData.GetStudentsByName(SearchTerm);
        }
    }
}
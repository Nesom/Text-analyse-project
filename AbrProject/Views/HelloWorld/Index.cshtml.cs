using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MvcMovie.Views.HelloWorld
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {

        }
        public string Answer { get; set; }
        public string Stroka { get; set; }
    }
}
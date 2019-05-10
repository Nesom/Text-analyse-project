using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        //FunctionClass<string> r = new FunctionClass<string>();
        //AnalyseHelper tr = new AnalyseHelper();
        Class c1 = new Class();
            //[HttpPost]
        public IActionResult Index()
        {
            return View("~/Views/HelloWorld/Index.cshtml", new MvcMovie.Views.HelloWorld.IndexModel());
        }

        [HttpPost]
        public IActionResult Index(string text)
        {
            var form = HttpContext.Request.Form;
            var answer = form["answerid"];
            var b = new StringBuilder();
            var a = TextAnalyzer.Analyze(answer.ToString());
            foreach(var e in a)
            {
                
                b.Append(e + "\n");
            }
           // c1.Answer = text + "a";
            return View(new Views.HelloWorld.IndexModel() { Answer = b.ToString()});
        }
        // 
        // GET: /HelloWorld/Welcome/

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace SO74497582.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : Controller
    {

        [HttpPost]
        [Route("test")]
        public async Task<IActionResult> Test()
        {
            using (StreamReader reader
                 = new StreamReader(Request.Body, Encoding.UTF8, true, 1024, true))
            {
                string content = await reader.ReadToEndAsync();
                return View();
            }
            ///Service1Client o = new Service1Client();
            //o.Test(myXML);


        }
    }
}

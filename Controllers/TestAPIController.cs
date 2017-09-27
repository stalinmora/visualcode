using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstAspNet.Controllers
{
    [Produces("application/json")]
    [Route("api/TestAPI")]
    public class TestAPIController : Controller
    {
        //[Route("api/TestAPI/Get")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> data = new List<string>();
            for(int i=1;i <= 1000;i++)
            {
                data.Add("ID :" + i.ToString());
                data.Add("Name :"+ i.ToString());
                data.Add("Address :"+i.ToString());
                data.Add("Email :"+i.ToString());
                data.Add("Telephone :"+i.ToString());
            }
            return data;
        }
    }
}
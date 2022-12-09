using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CalcClass;

namespace ApiCodeInside.Controllers
{
    public class ValuesController : Controller
    {
        // GET: api/<ValuesController>

        Calc calc = new Calc();

        [HttpGet("/average")]
        public int Myfunc([FromQuery] int[] nums)
        {
            return calc.Average(nums);
        }
        [HttpGet("/smallest")]
        public int Smallest([FromQuery] int[] nums)
        {
            return calc.Smallest(nums);
        }
        [HttpGet("/largest")]

        public int Largest([FromQuery] int[] nums)

        {
            return calc.Largest(nums);
        }

    }

}


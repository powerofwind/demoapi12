using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpGet("{input1}/{input2}")]
        public int GetAdd(int input1, int input2)
        {
            return input1 + input2;
        }

        [HttpGet("Minus/{input1}/{input2}")]
        public int GetMinus(int input1, int input2)
        {
            return input1 - input2;
        }

        [HttpGet("Multiply/{input1}/{input2}")]
        public int GetMultiply(int input1, int input2)
        {
            return input1 * input2;
        }

        [HttpGet("Divide/{input1}/{input2}")]
        public int GetDivide(int input1, int input2)
        {
            return input1 / input2;
        }

        [HttpGet("Logic/{input1}/{operation}/{input2}")]
        public int GetLogic(int input1, string operation, int input2)
        {
            var result = new CalculateLogic();
            return result.Calculate(input1, operation, input2);
        }
    }
}
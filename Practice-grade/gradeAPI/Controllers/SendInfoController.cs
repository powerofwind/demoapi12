using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gradeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace gradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendInfoController : ControllerBase
    {
        private static List<SScore> Students = new List<SScore>();

        [HttpPost]
        public void Post([FromBody] SScore Student)
        {
            var count = 1;
            //เก็บประวัตินักเรียนและเกรด
            //3
            var newstudent = new SScore
            {
                Id = ($"S{count++}"),
                // Id = Guid.NewGuid().ToString(),
                Name = Student.Name,
                Score = Student.Score,
                Grade = new GradeLogic().Calculate(Student.Score)
            };
         
            //2
            // var newstudent = new SScore
            // {
            //     Id = Guid.NewGuid().ToString(),
            //     Name = Student.Name,
            //     Score = Student.Score,
            // };
            // if (Student.Score >= 90)
            // {
            //     Student.Grade = "A";
            // }
            // else if (Student.Score >= 80 && Student.Score <= 89)
            // {
            //     Student.Grade = "B";
            // }
            // else if (Student.Score >= 70 && Student.Score <= 79)
            // {
            //     Student.Grade = "C";
            // }
            // else if (Student.Score >= 60 && Student.Score <= 69)
            // {
            //     Student.Grade = "D";
            // }
            // else
            // {
            //     Student.Grade = "F";
            // }

            //1 
            // var newstudent = new SScore
            // {
            //     Id = Guid.NewGuid().ToString(),
            //     Name = Student.Name,
            //     Score = Student.Score,
            //     Grade = Calculate(Student.Score)
            // };

            // Students.Add(newstudent);

        }

        [HttpGet]
        public ActionResult<IEnumerable<SScore>> Get()
        {
            return Students;
        }

        // 1
        // private string Calculate(int score)
        // {
        //     if (score >= 90)
        //     {
        //         return "A";
        //     }
        //     else if (score >= 80 && score <= 89)
        //     {
        //         return "B";
        //     }
        //     else if (score >= 70 && score <= 79)
        //     {
        //         return "C";
        //     }
        //     else if (score >= 60 && score <= 69)
        //     {
        //         return "D";
        //     }

        //     return "F";

    }

}
}

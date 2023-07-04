using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        //List<Exam> exam = new List<Exam>();

        [HttpGet("Getall")]
        public List<object> Get()
        {
            using var db = new BloggingContext();
            var result = new List<object>();
            result.AddRange(db.Exam);
            result.AddRange(db.Material);
            return result;
        }


        //[HttpGet("GetExam")]
        //public List<Exam> GetExam()
        //{
        //    using var db = new BloggingContext();
        //    return db.Exam.ToList();
        //}

        //[HttpGet("GetMaterial")]
        //public List<Material> GetMaterial()
        //{
        //    using var db = new BloggingContext();
        //    return db.Material.ToList();
        //}



    }
}

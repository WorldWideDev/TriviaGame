using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TriviaGame.Models;

namespace TriviaGame.Controllers
{
    [Route("api/")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private TriviaContext dbContext {get;}
        public QuestionsController(TriviaContext context)
        {
            dbContext = context;
        }
        // GET api/
        [HttpGet]
        public ActionResult<IEnumerable<Question>> Get()
        {
            return dbContext.Questions
                .Include(q => q.Topic)
                .Include(q => q.Answers).ToList();
        }

        // GET api/5
        [HttpGet("{id}")]
        public ActionResult<Question> Get(int id)
        {
            return dbContext.Questions
                .Include(q => q.Topic)
                .Include(q => q.Answers)
                .FirstOrDefault(q => q.QuestionId == id);
        }

        // // POST api/
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // // PUT api/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}

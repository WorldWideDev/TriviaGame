using Microsoft.EntityFrameworkCore;

namespace TriviaGame.Models
{
    public class TriviaContext : DbContext
    {
        public TriviaContext(DbContextOptions options) : base(options) {}
        public DbSet<Question> Questions {get;set;}
        public DbSet<Answer> Answers {get;set;}
        public DbSet<Topic> Topics {get;set;}
        
    }
}
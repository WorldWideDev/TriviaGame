using System.Collections.Generic;

namespace TriviaGame.Models
{
    public class Question
    {
        public int QuestionId {get;set;}
        public string Description {get;set;}
        public string Hint {get;set;}
        public int TopicId {get;set;}
        public Topic Topic {get;set;}
        public List<Answer> Answers {get;set;}

    }
    public class Answer
    {
        public int AnswerId {get;set;}
        public string Value {get;set;}
        public int QuestionId {get;set;}
        public bool IsCorrect {get;set;}
    }
    public class Topic
    {
        public int TopicId {get;set;}
        public string Title {get;set;}
        public string ImageUrl {get;set;}
    }
}
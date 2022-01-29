using System.Text.Json;

namespace BancoPrichinchaEncuesta.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Intro { get; set; }
        public string Type { get; set; }
        public List<Answer> Answers { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Question>(this);


    }
}

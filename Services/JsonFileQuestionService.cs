using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using BancoPrichinchaEncuesta.Models;
using Microsoft.AspNetCore.Hosting;

namespace BancoPrichinchaEncuesta.Services
{
    public class JsonFileQuestionService
    {
        public JsonFileQuestionService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json"); }
        }

        public IEnumerable<Question> GetQuestions()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                string json = jsonFileReader.ReadToEnd();
                //Console.WriteLine(json);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var array = JsonSerializer.Deserialize<Question[]>(json, options);
                Console.WriteLine(array[0]);
                return array;
            }
        }
    }
}

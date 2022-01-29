using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BancoPrichinchaEncuesta.Models;
using BancoPrichinchaEncuesta.Services;

namespace BancoPrichinchaEncuesta.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileQuestionService QuestionService;
        public IEnumerable<Question> Questions { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileQuestionService questionService)
        {
            _logger = logger;
            QuestionService = questionService;
        }

        public void OnGet()
        {
            Questions = QuestionService.GetQuestions();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WilliamToddSite.Models;

namespace WilliamToddSite.Controllers
{
    public class HomeController : Controller
    {
        private IForumRepository repository = null;
        //private IHttpContextAccessor http { get; set; }

        public HomeController(IForumRepository repository)
        {
            this.repository = repository;
        }
        /*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Overview()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            ViewBag.rScore = 0;
            ViewBag.qid = 1;

            Question q = QuestionDB.getQuestion(ViewBag.qid);
            ViewBag.QuestionText = q.Text;
            ViewBag.AnswerAText = q.AnswerA;
            ViewBag.AnswerBText = q.AnswerB;
           

            return View();
            
        }

        [HttpPost]
        public IActionResult Quiz(QuizModel model)
        {
            ViewBag.rScore = model.rScore;
            ViewBag.qid = model.qid + 1;

            if (model.Answer == "A") { ViewBag.rScore++; }
            if (model.Answer == "B") { ViewBag.rScore--; }
            

            // Get question text
            Question q = QuestionDB.getQuestion(ViewBag.qid);
            ViewBag.QuestionText = q.Text;
            ViewBag.AnswerAText = q.AnswerA;
            ViewBag.AnswerBText = q.AnswerB;
            

            ModelState.Clear();

            if (ViewBag.qid > 3)
            {
                ViewBag.Result = model.checkAnswer();
            }

            return View();
        }

        [HttpGet]
        public IActionResult Forum()
        {
            List<ForumModel> model = (List<ForumModel>)repository.SelectAll();
            ViewBag.Forum = model;
            return View(model);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View("Edit");
        }

        [HttpPost]
        public IActionResult Insert(ForumModel obj)
        {
            if(ModelState.IsValid)
            { 
                repository.Insert(obj);
                return RedirectToAction("Forum");
            }
            return View("Edit");
        }

        /*
        [HttpPost]
        public IActionResult Forum(ForumModel model)
        {

            if (model.CommentId > 0)
            {
                context.Forum.Update(model);
                context.SaveChanges();
            }
            else
            {
                context.Forum.Add(model);
                context.SaveChanges();
            }

            ViewBag.Forum = context.Forum.ToList();
            return View(model);
        }
        */
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ForumModel existing = repository.SelectByID(id);
            return View(existing);
        }
        
        [HttpPost]
        public IActionResult Edit(ForumModel obj)
        {
            if(ModelState.IsValid)
            { 
                repository.Update(obj);
                return RedirectToAction("Forum");
            }
            return View();
        }
        /*
        [HttpPost]
        public IActionResult Update()
        {
            repository.Update(obj);
            
            return View();
        }
        */
        [HttpGet]
        public IActionResult ConfirmDelete(int id)
        {
            ForumModel existing = repository.SelectByID(id);
            return View(existing);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

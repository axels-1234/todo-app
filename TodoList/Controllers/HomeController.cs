using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TodoList.Data;
using TodoList.Models;
using TodoList.Repositories;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            List<TodoModel> model = _dbContext.Todos.Select(x => new TodoModel
            {
                Id = x.Id,
                Thing = x.Thing.Trim(),
                Timestamp = x.Timestamp,
                UserId = x.UserId.Trim(),
                LastDate = x.LastDate
            })
            .Where(x => x.UserId == userId)
            .OrderBy(x => x.Timestamp).ToList();

            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Search(string q, int p)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var model = new SearchModel();

            if (!_dbContext.Users.Any(x => x.Id.Trim().ToLower() == userId.Trim().ToLower()))
                return View(model);

            model.q = q ?? "";
            model.p = p;
            model.Todos = _dbContext.Todos
                .Where(x => x.UserId.Trim() == userId)
                .Select(x => new TodoModel { Id = x.Id, LastDate = x.LastDate, Thing = x.Thing.Trim(), Timestamp = x.Timestamp, UserId = x.UserId })
                .OrderBy(x => CodeRepository.LevenshteinDistance(x.Thing, q ?? "") / (CodeRepository.Maximum((q ?? "").Length, x.Thing.Length) + CodeRepository.Minimum((q ?? "").Length, x.Thing.Length)))
                .Skip(p * CodeRepository.ResultsPerPage())
                .Take(CodeRepository.ResultsPerPage())
                .ToList();
            model.nrOfPages = (int)Math.Ceiling(_dbContext.Todos.Where(x => x.UserId.Trim() == userId).Count() / (decimal)CodeRepository.ResultsPerPage()) - 1;

            return View(model);
        }

        [Route("/meme")]
        public IActionResult Meme()
        {
            // https://redd.it/10rs7tp
            var model = CodeRepository.GetMeme();
            return View(model);
        }

        [HttpGet]
        [Authorize]
        [Route("/ny-sak")]
        public IActionResult NewTodoItem()
        {
            var model = new TodoModel();
            ViewBag.MinDate = DateTime.Now.ToString("yyyy-MM-dd");
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [Route("/ny-sak")]
        public IActionResult NewTodoItem(TodoModel model)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            model.UserId = userId;
            model.Timestamp = DateTime.Now;

            try
            {
                _dbContext.Todos.Add(model);
                _dbContext.SaveChanges();
                return Redirect("/");
            }
            catch { }
            ViewBag.MinDate = DateTime.Now.ToString("yyyy-MM-dd");
            return View(model);
        }

        [HttpGet]
        [Authorize]
        [Route("/redigera")]
        public IActionResult EditTodo(int id)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var model = _dbContext.Todos.FirstOrDefault(x => x.Id == id);
            if (model.UserId == userId)
                ViewBag.IsOwner = true;
            else
                return Redirect("/");
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [Route("/redigera")]
        public IActionResult EditTodo(TodoModel model)
        {
            try
            {
                model.Id = int.Parse(Request.Form["Id"]);
                model.UserId = Request.Form["UserId"];
                model.Timestamp = _dbContext.Todos.First(x => x.Id == model.Id).Timestamp;
            }
            catch
            {
                return View(model);
            }
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.IsOwner = true;
            if (ModelState.IsValid)
            {
                var m = _dbContext.Todos.FirstOrDefault(x => x.Id == model.Id);
                if (m == null)
                    return View(model);
                if (m.UserId == userId)
                {
                    _dbContext.Todos.First(x => x.Id == model.Id).Thing = model.Thing;
                    _dbContext.Todos.First(x => x.Id == model.Id).LastDate = model.LastDate;
                    _dbContext.SaveChanges();
                    return Redirect("/");
                }
            }
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult RemoveTodo(int id)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var item = _dbContext.Todos.First(x => x.Id == id);
            if (item.UserId == userId)
            {
                try
                {
                    _dbContext.Todos.Remove(item);
                    _dbContext.SaveChanges();
                }
                catch { }
            }
            return Redirect("/");
        }

        [Route("/om-oss")]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        [Route("/kontakt")]
        public IActionResult Contact()
        {
            var model = new ContactModel();
            return View(model);
        }

        [HttpPatch]
        [Authorize]
        [Route("/kontakt")]
        public IActionResult Contact(ContactModel model)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            model.UserId = userId;
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Contact.Add(model);
                    _dbContext.SaveChanges();
                    return Redirect("/");
                }
                catch { }
            }
            return View(model);
        }

        [Route("/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/robots.txt")]
        public IActionResult Robots()
        {
            string robotstext = "User-agent: *\n";
            robotstext += "Allow: /\n";
            robotstext += "Allow: /om-oss\n";
            robotstext += "Allow: /kontakt\n";
            robotstext += "Allow: /privacy\n";
            robotstext += "Disallow: /ny-sak\n";
            robotstext += "Disallow: /redigera/*\n";

            return this.Content(robotstext, "text/plain", Encoding.UTF8);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

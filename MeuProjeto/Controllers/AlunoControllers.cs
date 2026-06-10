using Microsoft.AspNetCore.Mvc;
public class AlunoController : Controller
{
   public IActionResult Index()

    {
       ViewBag.Nome = "Guilherme";
       ViewBag.Curso = "Ads";
       ViewBag.Semestre = "Primeiro";
       return View();
    }
}


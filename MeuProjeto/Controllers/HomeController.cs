using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuProjeto.Models;

namespace MeuProjeto.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult sobre()
    {
        return View();
    }

    
public IActionResult Boletim()
{
    List<string> disciplinas = new List<string>
    {
        "Matemática",
        "Português",
        "História",
        "Ciências",
        "Inglês"
    };

    List<double> notas = new List<double>
    {
        8.3,
        1.0,
        6.1,
        9.0,
        4.0
    };

    double media = 0;
    foreach (double nota in notas)
    {
        media += nota;
    }
    media = media / notas.Count;

    ViewBag.Disciplinas = disciplinas;
    ViewBag.Notas = notas;
    ViewBag.Media = media;

    return View();
}


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


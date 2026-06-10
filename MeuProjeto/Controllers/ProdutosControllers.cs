using Microsoft.AspNetCore.Mvc;

public class ProdutosController : Controller
{
    public IActionResult Index()
    {
        List<string> nomes = new List<string>
        {
            "Bomba Termonuclear",
            "Uranio",
            "Plutonio",
            "Mercurio",
            "Dentadura"
        };

    
        List<double> precos = new List<double>
        {
            0.99,
            150.00,
            300.00,
            650.00,
            1.000
        };

        ViewBag.Nomes = nomes;
        ViewBag.Precos = precos;
        ViewBag.Total = nomes.Count;

        return View();
    }
}
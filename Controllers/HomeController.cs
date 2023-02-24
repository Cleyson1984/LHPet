using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {// instancia Tipo clientes
        Cliente cliente1 = new Cliente(01, "Silveste Stow Longe", "005.310.555-54", "stow.PerThu@gmail.com.br", "Morroia");
        Cliente cliente2 = new Cliente(02, "John Trasd Wolta", "077.210.545-14", "Phui.Wolta@gmail.com.br" , "Meota");
        Cliente cliente3 = new Cliente(03, "Chuck L. Norris", "111.399.100-99", "norris.Champion@gmail.com.br","Nuke");
        Cliente cliente4 = new Cliente(04, "Stivem Kon Espilberg", "120.130.553-24", "et.casa@unimeil.com.br","ET");
        Cliente cliente5 = new Cliente(05, "Jou Stavar Leno", "110.220.225-11", "Blib.Oteka@gmail.com.br","Aypedy");

        //Lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

    // Instancia Tipo fornecedores

        Fornecedores fornecedores1 = new Fornecedores(01, "Crtl Z S/A", "14.344.545/0001-98", "Cr.Tlz@gmail.com.br");
        Fornecedores fornecedores2 = new Fornecedores(02, "C# tek S/A", "15.377.111/0001-22", "csharp.use@gmail.com.br");
        Fornecedores fornecedores3 = new Fornecedores(03, "LanPet S/A", "22.223.543/0001-12", "Lanpet.@gmail.com.br");
        Fornecedores fornecedores4 = new Fornecedores(04, "Teksat S/A", "33.344.532/0001-11", "teksat@gmail.com.br");
        Fornecedores fornecedores5 = new Fornecedores(05, "Fui Tek S/A", "43.112.444/0001-44", "Fuitek@gmail.com.br");

        //Lista de Fornecedores e atribui os fornecedores
        List<Fornecedores> listaFornecedores = new List<Fornecedores>();
        listaFornecedores.Add(fornecedores1);
        listaFornecedores.Add(fornecedores2);
        listaFornecedores.Add(fornecedores3);
        listaFornecedores.Add(fornecedores4);
        listaFornecedores.Add(fornecedores5);

        ViewBag.listaFornecedores = listaFornecedores;

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

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
    {
        Cliente clienteOne = new Cliente(1, "Pedro", "000.000.000-00", "pedro.h.silva60@aluno.senai.br", "Scooby");
        Cliente clienteTwo = new Cliente(2, "Victoria", "111.111.111-11", "victoria@gmail.com", "Floquinho");
        Cliente clienteThree = new Cliente(3, "Joao", "222.222.222-22", "joao@gmail.com", "Floquinho2");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(clienteOne);
        listaClientes.Add(clienteTwo);
        listaClientes.Add(clienteThree);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedorOne = new Fornecedor(1, "ClinicalPet", "00.000.000/0000-00", "clinicalpet@gmail.com");
        Fornecedor fornecedorTwo = new Fornecedor(2, "Petz", "11.111.111/1111-11", "petz@gmail.com");
        Fornecedor fornecedorThree = new Fornecedor(3, "Dogz", "22.222.222/2222-22", "dogz@gmail.com");

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedorOne);
        listaFornecedor.Add(fornecedorTwo);
        listaFornecedor.Add(fornecedorThree);

        ViewBag.listaFornecedor = listaFornecedor;
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

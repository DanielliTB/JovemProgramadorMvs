using JovemProgramadorMvs.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace JovemProgramadorMvs.Controllers
{
    public class ProfessorController : Controller
    {
        public ProfessorController()
        {

        }

        public IActionResult Index()
        {
            return View();
        
        }

        public IActionResult BuscarEnderecoP()
        {
            return View();

        }

    }
}
        
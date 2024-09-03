﻿using CadAlunoMVC.DAO;
using CadAlunoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadAlunoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            AlunoDAO dao = new AlunoDAO();
            List<AlunoViewModel> lista = dao.Listagem();
            return View("index", lista);
        }
    }

}

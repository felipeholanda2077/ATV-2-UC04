using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ATV_2_UC4.Models;

namespace ATV_2_UC4.Controllers
{
    public class UsuarioController: Controller
    {
        public IActionResult Listagem(){

            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> Lista = ur.Listar();
            return View(Lista);

        }
    }
}
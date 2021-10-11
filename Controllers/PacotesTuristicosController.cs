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
    public class PacotesTuristicosController: Controller
    {
        
        public IActionResult CadastrarPT(){
            return View();
        }

         public IActionResult EditarPT(int Id){
           PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
           PacotesTuristicos PacoteEncontrado = pr.BuscarPorIdPT(Id);
           return View(PacoteEncontrado);
       }

       [HttpPost]
        public IActionResult  EditarPT(PacotesTuristicos Pacote){

            PacotesTuristicosRepository pr = new PacotesTuristicosRepository();

            pr.EditarPT(Pacote);

            return RedirectToAction("ListagemPT","PacotesTuristicos");

        }
        
       public IActionResult ExcluirPT(int Id){
           PacotesTuristicosRepository pr = new PacotesTuristicosRepository();
           PacotesTuristicos PacoteEncontrado = pr.BuscarPorIdPT(Id);
           pr.ExcluirPT(PacoteEncontrado);
           return RedirectToAction("ListagemPT","PacotesTuristicos");
       }


        [HttpPost]
        public IActionResult  CadastroPT(PacotesTuristicos Pacote){

            PacotesTuristicosRepository pt = new PacotesTuristicosRepository();

            pt.CadastrarPT(Pacote);

            return RedirectToAction("ListagemPT","PacotesTuristicos");

        }

        public IActionResult ListagemPT(){

            PacotesTuristicosRepository pt = new PacotesTuristicosRepository();
            List<PacotesTuristicos> ListaPt = pt.ListarPT();
            return View(ListaPt);
        }
    }
}
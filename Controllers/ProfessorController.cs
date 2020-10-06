using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using provaquesta04.Context;
using provaquesta04.Models;

namespace provaquesta04.Controllers
{
    public class ProfessorController : Controller
    {
        private Contexto db = new Contexto();


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Endereco,Telefone,Email,Disciplina")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professors.Add(professor);
                await db.SaveChangesAsync();
                
            }

            return View(professor);
        }


        

      


       

       

      
        
    }
}

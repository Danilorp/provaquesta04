using provaquesta04.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace provaquesta04.Context
{
    public class Contexto : DbContext
    {
        public DbSet <Professor> Professors {get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SkriptPrototyp.Models
{
    //Skript Object
    public class Skript
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Displayname { get; set; }

        public string Discription { get; set; }

        public string Status { get; set; }

    }

    //Adds the DB
    public class SkriptDBContext : DbContext
    {
        private object p;

        public SkriptDBContext()
        {
        }

        public SkriptDBContext(object p)
        {
            this.p = p;
        }

        public DbSet<Skript> Skripte { get; set; }
    }
}
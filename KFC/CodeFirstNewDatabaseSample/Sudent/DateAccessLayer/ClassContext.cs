using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sudent.Models;

namespace Sudent.DateAccessLayer
{
  public  class ClassContext:DbContext
    {
        public DbSet<Class1> Clas { get; set; }
        public DbSet<Class2> Stu { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudent.Models
{
   public  class Class1
    {
        public int Class1Id { get; set; }
        public string ClasName { get; set; }
        //导航属性，目的是能够通过博客对象访问对应的一组贴子
        public virtual List<Class2> Student { get; set; }

    }
}

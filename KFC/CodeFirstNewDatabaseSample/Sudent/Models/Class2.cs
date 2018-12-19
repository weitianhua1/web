using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudent.Models
{
   public  class Class2
    {
        public int Class2Id { get; set; }
        public string StuName { get; set; }

        //相当于数据库外码（外键）
        public int Class1Id { get; set; }
        //导航属性--目的是能够通过贴子对象访问对应的博客
        public virtual Class1 Clas { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sudent.Models;
using Sudent.BusinessLayer;

namespace Sudent
{
    class Program
    {
        static void Main(string[] args)
        {

            //crateclass();
            QueryClass();
            Update();
            QueryClass();
            Delete();
            Console.WriteLine("按任意键退出");
                Console.ReadKey();
            }
            static void crateClass()
        {
                Console.WriteLine("请输入一个班级名称");
                //接收用户输入传给name
                string name = Console.ReadLine();
                //创建博客对象
                Class1 clas = new Class1();
                clas.ClasName = name;
                ClassBusinessLayer bbl = new ClassBusinessLayer();
                bbl.Add(clas);
            }

        static void QueryClass()
        {
            ClassBusinessLayer bbl = new ClassBusinessLayer();
            var clas = bbl.Query();
            foreach (var item in clas)
            {
                Console.WriteLine(item.Class1Id + " " + item.ClasName);
            }
        }

        static void Update()
        {
            Console.WriteLine("请输入班级ID");
            int id = int.Parse(Console.ReadLine());
            ClassBusinessLayer bbl = new ClassBusinessLayer();
            Class1 clas = bbl.Query(id);
            Console.WriteLine("请输入新名字");
            string name = Console.ReadLine();
            clas.ClasName = name;
            bbl.Update(clas);
        }

        //删除
        static void Delete()
        {

            ClassBusinessLayer bbl = new ClassBusinessLayer();
            Console.Write("请输入删除班级id");
            int id = int.Parse(Console.ReadLine());
            Class1 clas = bbl.Query(id);
            bbl.Delete(clas);
        }
    }
    }


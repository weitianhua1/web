using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cad> cadList = new List<Cad>();

            Cad ph = new Cad();
            ph.Name = "马丁马";
            ph.Price = 99;

            cadList.Add(ph);

            ph = new Cad();
            ph.Name = "马甲鹅";
            ph.Price = 88;

            cadList.Add(ph);

            foreach (var item in cadList)
            {
                Console.WriteLine("名称;{0} 价格:{1}", item.Name, item.Price);
            }
            Console.ReadLine();

        }
    }
}

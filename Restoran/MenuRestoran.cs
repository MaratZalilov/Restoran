using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class MenuRestoran
    {
        public void Comparison(List<string> menu,string order)
        {
            List<string> list = new List<string>();

            foreach(var str2 in menu)
            {
                if (order.Contains(str2))
                {
                    list.Add(str2 + ' ') ;
                }
            }
            foreach(var str3 in list)
            {
                order.ToUpper();
                Console.Write(str3);
            }
        }
    }
}

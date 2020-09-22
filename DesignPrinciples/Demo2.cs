using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
   /// <summary>
   /// 【外部系统】 所以只需要
   /// </summary>
    public class Demo2 : IOrderService2
    {
        public void Query()
        {
            Console.WriteLine("查询");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    /// <summary>
    /// 孔雀(继承鸟类)
    /// </summary>
    public class Peacock : Bird
    {
        public void Open()
        {
            Console.WriteLine($"我是一只{this.Name},我可以开屏!");
        }
    }
}

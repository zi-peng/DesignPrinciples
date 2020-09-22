using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    /// <summary>
    /// 企鹅
    /// </summary>
    public class Penguin : Animal
    {
        public void Open()
        {
            Console.WriteLine($"{this.Name}身体又肥又圆!我南极的标志性动物");
        }
        public override void Address()
        {
            Console.WriteLine($"{this.Name},我准备前往北极生活!");
        }
    }
}

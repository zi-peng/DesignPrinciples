using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    /// <summary>
    /// 遵循接口隔离原则(提倡使用多个专门的接口，而不是使用一个总的接口去进行管理，不同的接口类，负责需要的业务操作即可)
    /// 1.假设现在有需求：内部系统实现增删改查操作、外部系统只提供查询的接口。那么应该怎样处理呢？
    /// 2.我们不可能将这个两个接口写在一个接口总类中，因为外部系统只需要查询，所以我们定义两个接口类，
    /// 一个类负责增删改，另外一个类负责查，在内部系统则需要继承两个接口类，而外部系统继承查这个接口类即可
    /// 
    /// 【内部系统】
    /// 继承接口，以实现对应的方法，这里实现的是两个接口类的方法
    /// </summary>
    public class Demo : IOrderService1, IOrderService2
    {
        public void Add()
        {
            Console.WriteLine("添加");
        }

        public void Del()
        {
            Console.WriteLine("删除");
        }

        public void Edit()
        {
            Console.WriteLine("修改");
        }
        /// <summary>
        /// 时间接口方法显示的引用指的是，这个接口被多少次实现
        /// </summary>
        public void Query()
        {
            Console.WriteLine("查询");
        }
    }
}

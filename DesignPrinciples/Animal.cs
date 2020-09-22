using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    /// <summary>
    /// 动物
    /// </summary>
    public class Animal
    {
        public string Name => this.GetType().Name;
        /// <summary>
        /// 吃
        /// </summary>
        public void Eat()
        {
            Console.WriteLine($"我是一只{this.Name},我需要吃食物!");
        }
        /// <summary>
        /// 喝
        /// </summary>
        public void Drink()
        {
            Console.WriteLine($"我是一只{this.Name},我需要喝水!");
        }
        /// <summary>
        /// 虚方法的目的在于给子程序一个重写的特性，避免子类重写一个类的方法，到后期不利于维护
        /// 这种方法不利于大方面使用，否则的话失去了父类存在的意义！大多数直接调用父类的方法即可是极好的
        /// </summary>
        public virtual void Address()
        {
            Console.WriteLine($"{this.Name}住的地方在南极!");
        }
    }
}

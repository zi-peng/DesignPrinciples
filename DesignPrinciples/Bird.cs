using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    /// <summary>
    /// 鸟类的父类(鸟类)
    /// </summary>
    public class Bird: Animal
    {
        //public string Name => this.GetType().Name;

        /// <summary>
        /// 会飞(从一般的角度考虑，鸟大部分都会飞，但是现在企鹅加了进来，企鹅满足吃喝方法，但是它不会飞，
        /// 那么我们应该把吃喝方法提出来，新建一个动物类，动物都需要喝水和吃东西，鸟类里面只留Fly的方法)
        /// </summary>
        public void Fly()
        {
            Console.WriteLine($"我是一只{this.Name},我可以飞!");
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Unity;

namespace DesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.单一职责    一个类中只负责特定的一些功能，和其他的类尽量不耦合，这样在修改其他类的方法的时候当前类不受影响
            //2.开闭原则    开闭的原则对添加(扩展)开放，在新增需求的时候，尽量不是修改原来的代码，而是填上新的代码，如果为了新功能
            //修改旧的代码 则有可能会出现旧的功能不可用的情况！
            //3.里氏替换原则  子类可以扩展父类的功能，但是不能对父类的原有的功能进行修改
            //Penguin penguin = new Penguin();
            //penguin.Drink();
            //penguin.Eat();
            //penguin.Open();
            //penguin.Address();
            //Peacock peacock = new Peacock();
            //peacock.Fly();
            //peacock.Open();
            ////4. 接口隔离原则 详见ICommon 类
            ////5.合成复用原则  对象和对象是包含的关系，可以复用，减少代码量!  复用 has-a  (子承父类)继承  (学生)is-a(人类)
            ////6.依赖倒置

            //使用工厂来选择调用哪个类
            //Father father1 = new Father("Book");
            //father1.Read();

            ////忽略工厂直接调用，传入实现接口的类中
            //Father father = new Father(new Book());
            //father.Read();

            //Father paper = new Father(new NewsPaper());
            //paper.Read();

            //创建容器
            var container = new UnityContainer();
            //扫描程序集，配置文件
            //在容器里面注册接口和实现类，创建依赖关系
            container.RegisterType<IReader, NewsPaper>();
            //在容器里面注册Father
            container.RegisterType<Father>();

            //从容器里面拿出要使用的类，容器会自行创建father对
            //还会从容器里去拿到他所有依赖的对象，并且注入进来
            var fatherResolve = container.Resolve<Father>();
            //调用方法
            fatherResolve.Read();
            Console.ReadKey();
            // 创建对 CPU 占用百分比的性能计数器。
            //var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ////// 创建内存占用字节数的性能计数器
            //var ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            //var i = 1;
            //Queue<float> queue = new Queue<float>(3);
            //float[] a = new float[] { 100,100,100,100,100,50,50,10,20,30,50 };
            //foreach (var item in a)
            //{
            //    Console.WriteLine(i + "cpu:" + item);
            //    if (queue.Count < 1)
            //    {
            //        queue.Enqueue(0);
            //        queue.Enqueue(0);
            //    }
            //    if (queue.Count < 2)
            //    {
            //        queue.Enqueue(0);
            //    }
            //    queue.Enqueue(item);
            //    if (queue.Count > 3)
            //        queue.Dequeue();
            //    float avg = queue.Average();
            //    Console.WriteLine("求平均值：" + avg);
            //    i++;
            //}
            //while (i < 10)
            //{
            //    float cpu = cpuCounter.NextValue();
            //    float ram = ramCounter.NextValue();
            //    Thread.Sleep(1000);
            //    Console.WriteLine(i + "cpu:" + cpu);
            //    Console.WriteLine(i + "ram:" + ram);

            //    i++;
            //}

        }
    }
}

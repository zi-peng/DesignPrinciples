using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public class Father
    {
        private IReader Reader { get; set; }

        /// <summary>
        /// 返回接口类(依赖于接口)
        /// </summary>
        /// <param name="reader">参数改为接口类型</param>
        public Father(IReader reader)
        {
            Reader = reader;
        }
        /// <summary>
        /// 依赖于工厂
        /// </summary>
        /// <param name="readerName"></param>
        public Father(string readerName)
        {
            //相当于返回当前的实现的接口对象类， 这里面向的是接口进行编程
            Reader = ReaderFactory.GetReader(readerName);
        }
        public void Read()
        {
            Console.WriteLine("爸爸开始给孩子讲故事了");
            Console.WriteLine(Reader.GetContent());
        }
    }
}

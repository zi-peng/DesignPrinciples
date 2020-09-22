using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public class Book : IReader
    {
        /// <summary>
        /// 实现阅读的接口
        /// </summary>
        /// <returns></returns>
        public string GetContent() 
        {
            return "开始讲故事了!";
        }
        public string GetContent1()
        {
            return "开始讲故事了!";
        }
    }
}

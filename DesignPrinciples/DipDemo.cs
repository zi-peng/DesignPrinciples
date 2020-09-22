using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public class DipDemo
    {

    }
    public interface IReader
    {
        /// <summary>
        /// 阅读的内容
        /// </summary>
        /// <returns></returns>
        public string GetContent();
    };
}

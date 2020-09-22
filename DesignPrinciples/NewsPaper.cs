using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public class NewsPaper : IReader
    {
        public string GetContent()
        {
            return "今天的新闻是王思聪被限制高消费!";
        }
    }
}

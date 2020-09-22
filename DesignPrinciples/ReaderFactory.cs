using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    /// <summary>
    /// 阅读工厂
    /// </summary>
    public static class ReaderFactory
    {
        public static IReader GetReader(string rederType)
        {
            if (string.IsNullOrWhiteSpace(rederType))
            {
                return null;
            }
            switch (rederType)
            {
                case "Book":
                    return new Book();
                case "NewsPaper":
                    return new NewsPaper();
                default:
                    return null;
            }
        }
    }
}

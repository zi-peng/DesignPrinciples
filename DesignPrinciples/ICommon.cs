using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public class ICommon
    {
    
    }
    #region 备注： 一个服务只需要查询方法，另外一个所有方法都要实现，所以定义了两个接口类
    #endregion
    public interface IOrderService1
    {
        //增删改
        void Add();
        void Edit();
        void Del();
    }
    public interface IOrderService2
    {
        void Query(); //查询
    }
}

using factory_method.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method.Creators
{
    public interface IBookCreator
    {
        IBook GetBook();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using factory_method.Products;

namespace factory_method.Creators
{
    public class ComicCreator : IBookCreator
    {
        public IBook GetBook()
        {
            return new Comic();
        }
    }
}

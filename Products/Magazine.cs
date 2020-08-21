using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method.Products
{
    public class Magazine : IBook
    {
        public string Type => "Magazine";
    }
}

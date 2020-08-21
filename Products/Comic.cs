using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method.Products
{
    public class Comic : IBook
    {
        public string Type { 
            get => "comic";
        }

    }
}

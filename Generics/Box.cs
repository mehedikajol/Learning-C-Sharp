using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box
    {
        public int length { set; get; }
        public int width { set; get; } 
        public int height { set; get; }

        public int Area() => length * width;
        public int Volume() => length * width * height;
    }
}

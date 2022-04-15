using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box<T>
    {
        public T Length { set; get; }
        public T Width { set; get; } 
        public T Height { set; get; }

        // public T Area() => Length * Width;
        // public T Volume() => Length * Width * Height;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3
{
    class Rectangle1
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }
    }
    class Square1
    {
        public virtual int SideLength { get; set; }
       public int GetArea()
        {
            return SideLength * SideLength;
        }
    }


}

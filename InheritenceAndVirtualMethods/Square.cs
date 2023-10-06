using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndVirtualMethods
{
    // Square - vaikine klase
    internal class Square : Polygon // Polygon - tevine klase
    {
        public double Size { get; set; }

        public Square()
        {
            NumberOfAngles = 4;     // NumberOfAngles ateina is tevines Polygon klases
        }

        public Square(double size)
        {
            Size = size;
            NumberOfAngles = 4;
        }
    }
}

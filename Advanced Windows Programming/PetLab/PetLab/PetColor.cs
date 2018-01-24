using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLab
{
    [Flags()]
    public enum PET_COLOR
    {
       White = 1,
       Black = 2,
       Brown = 4,
       Red = 8,
       Blue = 16,
       Green = 32,
       Gray = 64,
    }
    
}

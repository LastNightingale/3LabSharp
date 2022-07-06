using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LabSharp
{
    internal interface ICrypt
    {
        public ICryptographer CreateCryptographer();
    }
}

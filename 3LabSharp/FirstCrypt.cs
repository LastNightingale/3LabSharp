using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LabSharp
{
    internal class FirstCrypt : ICrypt
    {
        public ICryptographer CreateCryptographer()
        {
            return new FirstCryptographer();
        }
    }
}

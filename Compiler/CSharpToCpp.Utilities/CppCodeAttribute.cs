using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToCpp.Utilities
{
    public class CppCodeAttribute : Attribute
    {
        public CppCodeAttribute(string fromCode, string cppCode)
        {
            CppCode = cppCode;
            CppFrom = fromCode;
        }

        public string CppFrom { get; }
        public string CppCode { get; }
    }
}

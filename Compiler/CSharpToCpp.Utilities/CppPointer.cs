using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToCpp.Utilities
{
    /// <summary>
    /// Translate this type to a pointer type.  So UObject will become UObject*
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct|AttributeTargets.Parameter)]
    public class CppPointer : Attribute
    {
    }

    /// <summary>
    /// Do not make a pointer for this method
    /// </summary>
    [AttributeUsage(AttributeTargets.GenericParameter)]
    public class CppNoPointer : Attribute
    {
    }
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyBag.h")]
///<summary>Getter and setter result code.</summary>
public enum EPropertyBagResult {
	Success=0,
	TypeMismatch=1,
	OutOfBounds=2,
	PropertyNotFound=3,
}

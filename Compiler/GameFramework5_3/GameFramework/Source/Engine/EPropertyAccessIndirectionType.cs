namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
///<summary>The type of an indirection</summary>
public enum EPropertyAccessIndirectionType {
	Offset=0,
	Object=1,
	Array=2,
	ScriptFunction=3,
	NativeFunction=4,
}

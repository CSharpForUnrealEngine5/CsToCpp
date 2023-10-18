namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
///<summary>For object nodes, we need to know what type of object we are looking at so we can cast appropriately</summary>
public enum EPropertyAccessObjectType {
	None=0,
	Object=1,
	WeakObject=2,
	SoftObject=3,
}

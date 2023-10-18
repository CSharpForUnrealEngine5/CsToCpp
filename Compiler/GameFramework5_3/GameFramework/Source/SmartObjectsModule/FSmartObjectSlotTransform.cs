namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime data holding the final slot transform (i.e. parent transform applied on slot local offset and rotation)</summary>
[CppInclude("SmartObjectRuntime.h")]
public partial struct FSmartObjectSlotTransform {
	public FTransform Transform;
}

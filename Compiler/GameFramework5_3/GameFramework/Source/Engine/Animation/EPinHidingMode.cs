namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNodeBase.h")]
///<summary>The display mode of editable values on an animation node.</summary>
[CppEnumInNamespace]
public enum EPinHidingMode {
	NeverAsPin=0,
	PinHiddenByDefault=1,
	PinShownByDefault=2,
	AlwaysAsPin=3,
}

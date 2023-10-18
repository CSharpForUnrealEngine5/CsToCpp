namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Swizzle axis components of an input value.</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierSwizzleAxis : UInputModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Default to XY swap, useful for binding 1D inputs to the Y axis.</summary>
	public EInputAxisSwizzle Order;
}

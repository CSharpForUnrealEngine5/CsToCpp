#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Swizzle axis components of an input value.</summary>
[CppInclude("InputModifiers.h")]
public partial class UInputModifierSwizzleAxis : UInputModifier {
	///<summary>Default to XY swap, useful for binding 1D inputs to the Y axis.</summary>
	public EInputAxisSwizzle Order;
}

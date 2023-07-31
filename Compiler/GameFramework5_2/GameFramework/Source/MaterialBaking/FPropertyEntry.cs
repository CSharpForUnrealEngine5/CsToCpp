#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure to represent a single property the user wants to bake out for a given set of materials</summary>
[CppInclude("MaterialOptions.h")]
public partial struct FPropertyEntry {
	public EMaterialProperty Property;
	public bool bUseCustomSize;
	public FIntPoint CustomSize;
	public bool bUseConstantValue;
	public float ConstantValue;
}

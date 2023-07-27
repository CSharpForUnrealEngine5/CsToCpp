#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialOptions.h")]
///<summary>Structure to represent a single property the user wants to bake out for a given set of materials</summary>
public partial struct FPropertyEntry {
// PropertyEntry
	public EMaterialProperty Property;
	public bool bUseCustomSize;
	public FIntPoint CustomSize;
	public bool bUseConstantValue;
	public float ConstantValue;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure linking a material expression input with a physical material. For use by UMaterialExpressionPhysicalMaterialOutput.</summary>
[CppInclude("Materials/MaterialExpressionPhysicalMaterialOutput.h")]
public partial struct FPhysicalMaterialTraceInput {
	public UPhysicalMaterial PhysicalMaterial;
	public FExpressionInput Input;
}

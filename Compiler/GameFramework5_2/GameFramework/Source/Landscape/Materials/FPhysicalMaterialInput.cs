namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure linking a material expression input with a physical material. For use by UMaterialExpressionLandscapePhysicalMaterialOutput.</summary>
[CppInclude("Materials/MaterialExpressionLandscapePhysicalMaterialOutput.h")]
public partial struct FPhysicalMaterialInput {
	public UPhysicalMaterial PhysicalMaterial;
	public FExpressionInput Input;
}

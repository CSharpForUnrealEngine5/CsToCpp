#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstanceConstant.h")]
///<summary>Material Instances may be used to change the appearance of a material without incurring an expensive recompilation of the material.</summary>
public partial class UMaterialInstanceConstant : UMaterialInstance {
// MaterialInstanceConstant
	public FGuid ParameterStateId;
	public UPhysicalMaterialMask PhysMaterialMask;
	public float K2_GetScalarParameterValue(string ParameterName) { return default; }
	public UObject K2_GetTextureParameterValue(string ParameterName) { return default; }
	public FLinearColor K2_GetVectorParameterValue(string ParameterName) { return default; }
	public void SetNaniteOverrideMaterial(bool bInEnableOverride,UObject InOverrideMaterial) {}
}

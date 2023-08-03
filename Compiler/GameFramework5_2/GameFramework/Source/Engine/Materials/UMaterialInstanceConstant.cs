#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material Instances may be used to change the appearance of a material without incurring an expensive recompilation of the material.</summary>
[CppInclude("Materials/MaterialInstanceConstant.h")]
public partial class UMaterialInstanceConstant : UMaterialInstance {
	public static UClass StaticClass() {return default;}
	///<summary>Unique ID for this material instance&#39;s parameter set</summary>
	public FGuid ParameterStateId;
	///<summary>Physical material mask to use for this graphics material. Used for sounds, effects etc.</summary>
	public UPhysicalMaterialMask PhysMaterialMask;
	///<summary>Get the scalar (float) parameter value from an MIC</summary>
	public  float K2_GetScalarParameterValue(string ParameterName) { return default; }
	///<summary>Get the MIC texture parameter value</summary>
	public  UTexture K2_GetTextureParameterValue(string ParameterName) { return default; }
	///<summary>Get the MIC vector parameter value</summary>
	public  FLinearColor K2_GetVectorParameterValue(string ParameterName) { return default; }
	///<summary>Set an override material which will be used when rendering with nanite.</summary>
	public  void SetNaniteOverrideMaterial(bool bInEnableOverride,UMaterialInterface InOverrideMaterial) {}
}

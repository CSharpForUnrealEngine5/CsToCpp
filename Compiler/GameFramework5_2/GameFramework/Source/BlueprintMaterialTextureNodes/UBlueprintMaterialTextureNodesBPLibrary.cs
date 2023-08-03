#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>*      Function library class.</summary>
[CppInclude("BlueprintMaterialTextureNodesBPLibrary.h")]
public partial class UBlueprintMaterialTextureNodesBPLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Samples a texel from a Texture 2D with VectorDisplacement Compression</summary>
	public static FLinearColor Texture2D_SampleUV_EditorOnly(UTexture2D Texture,FVector2D UV) { return default; }
	///<summary>Samples an array of values from a Texture Render Target 2D. Currently only 4 channel formats are supported.</summary>
	public static TArray<FLinearColor> RenderTarget_SampleRectangle_EditorOnly(UTextureRenderTarget2D InRenderTarget,FLinearColor InRect) { return default; }
	///<summary>Samples a value from a Texture Render Target 2D. Currently only 4 channel formats are supported.</summary>
	public static FLinearColor RenderTarget_SampleUV_EditorOnly(UTextureRenderTarget2D InRenderTarget,FVector2D UV) { return default; }
	///<summary>Creates a new Material Instance Constant asset</summary>
	public static UMaterialInstanceConstant CreateMIC_EditorOnly(UMaterialInterface Material,string Name/*="MIC_"*/) { return default; }
	///<summary>UpdateMIC</summary>
	public static void UpdateMIC(UMaterialInstanceConstant MIC) {}
	///<summary>Sets a Scalar Parameter value in a Material Instance Constant</summary>
	public static bool SetMICScalarParam_EditorOnly(UMaterialInstanceConstant Material,string ParamName/*="test"*/,float Value/*=0.0f*/) { return default; }
	///<summary>Sets a Vector Parameter value in a Material Instance Constant</summary>
	public static bool SetMICVectorParam_EditorOnly(UMaterialInstanceConstant Material,string ParamName,FLinearColor Value/*=new FLinearColor(0,0,0,0)*/) { return default; }
	///<summary>Sets a Texture Parameter value in a Material Instance Constant</summary>
	public static bool SetMICTextureParam_EditorOnly(UMaterialInstanceConstant Material,string ParamName,UTexture2D Texture/*=nullptr*/) { return default; }
	///<summary>Overrides the Shading Model of a Material Instance Constant</summary>
	public static bool SetMICShadingModel_EditorOnly(UMaterialInstanceConstant Material,EMaterialShadingModel ShadingModel/*=MSM_DefaultLit*/) { return default; }
	///<summary>Overrides the Blend Mode of a Material Instance Constant</summary>
	public static bool SetMICBlendMode_EditorOnly(UMaterialInstanceConstant Material,EBlendMode BlendMode/*=BLEND_Opaque*/) { return default; }
	///<summary>Overrides the Two Sided setting of a Material Instance Constant</summary>
	public static bool SetMICTwoSided_EditorOnly(UMaterialInstanceConstant Material,bool TwoSided/*=false*/) { return default; }
	///<summary>Overrides the IsThinSurface setting of a Material Instance Constant</summary>
	public static bool SetMICIsThinSurface_EditorOnly(UMaterialInstanceConstant Material,bool bIsThinSurface/*=false*/) { return default; }
	///<summary>Overrides the Blend Mode of a Material Instance Constant</summary>
	public static bool SetMICDitheredLODTransition_EditorOnly(UMaterialInstanceConstant Material,bool DitheredLODTransition/*=false*/) { return default; }
}

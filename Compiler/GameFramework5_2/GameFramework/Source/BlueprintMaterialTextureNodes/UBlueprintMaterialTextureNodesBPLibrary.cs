#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintMaterialTextureNodesBPLibrary.h")]
///<summary>*      Function library class.</summary>
public partial class UBlueprintMaterialTextureNodesBPLibrary : UBlueprintFunctionLibrary {
// BlueprintMaterialTextureNodesBPLibrary
	public static FLinearColor Texture2D_SampleUV_EditorOnly(UTexture2D Texture,FVector2D UV) { return default; }
	public static TArray<FLinearColor> RenderTarget_SampleRectangle_EditorOnly(UTextureRenderTarget2D InRenderTarget,FLinearColor InRect) { return default; }
	public static FLinearColor RenderTarget_SampleUV_EditorOnly(UTextureRenderTarget2D InRenderTarget,FVector2D UV) { return default; }
	public static UMaterialInstanceConstant CreateMIC_EditorOnly(UMaterialInterface Material,string Name/*="MIC_"*/) { return default; }
	public static void UpdateMIC(UMaterialInstanceConstant MIC) {}
	public static bool SetMICScalarParam_EditorOnly(UMaterialInstanceConstant Material,string ParamName/*="test"*/,float Value/*=0.0f*/) { return default; }
	public static bool SetMICVectorParam_EditorOnly(UMaterialInstanceConstant Material,string ParamName,FLinearColor Value/*=new FLinearColor(0,0,0,0)*/) { return default; }
	public static bool SetMICTextureParam_EditorOnly(UMaterialInstanceConstant Material,string ParamName,UTexture2D Texture/*=nullptr*/) { return default; }
	public static bool SetMICShadingModel_EditorOnly(UMaterialInstanceConstant Material,EMaterialShadingModel ShadingModel/*=MSM_DefaultLit*/) { return default; }
	public static bool SetMICBlendMode_EditorOnly(UMaterialInstanceConstant Material,EBlendMode BlendMode/*=BLEND_Opaque*/) { return default; }
	public static bool SetMICTwoSided_EditorOnly(UMaterialInstanceConstant Material,bool TwoSided/*=false*/) { return default; }
	public static bool SetMICIsThinSurface_EditorOnly(UMaterialInstanceConstant Material,bool bIsThinSurface/*=false*/) { return default; }
	public static bool SetMICDitheredLODTransition_EditorOnly(UMaterialInstanceConstant Material,bool DitheredLODTransition/*=false*/) { return default; }
}

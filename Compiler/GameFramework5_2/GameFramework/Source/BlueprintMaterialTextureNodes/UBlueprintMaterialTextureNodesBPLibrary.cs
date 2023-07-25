#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintMaterialTextureNodesBPLibrary.h")]
///<summary>*      Function library class.</summary>
public partial class UBlueprintMaterialTextureNodesBPLibrary : UBlueprintFunctionLibrary {
// BlueprintMaterialTextureNodesBPLibrary
	public FLinearColor Texture2D_SampleUV_EditorOnly(UObject Texture,FVector2D UV) { return default; }
	public TArray<FLinearColor> RenderTarget_SampleRectangle_EditorOnly(UObject InRenderTarget,FLinearColor InRect) { return default; }
	public FLinearColor RenderTarget_SampleUV_EditorOnly(UObject InRenderTarget,FVector2D UV) { return default; }
	public UObject CreateMIC_EditorOnly(UObject Material,string Name/*="MIC_"*/) { return default; }
	public void UpdateMIC(UObject MIC) {}
	public bool SetMICScalarParam_EditorOnly(UObject Material,string ParamName/*="test"*/,float Value/*=0.0f*/) { return default; }
	public bool SetMICVectorParam_EditorOnly(UObject Material,string ParamName,FLinearColor Value/*=new FLinearColor(0,0,0,0)*/) { return default; }
	public bool SetMICTextureParam_EditorOnly(UObject Material,string ParamName,UObject Texture/*=nullptr*/) { return default; }
	public bool SetMICShadingModel_EditorOnly(UObject Material,byte ShadingModel/*=MSM_DefaultLit*/) { return default; }
	public bool SetMICBlendMode_EditorOnly(UObject Material,byte BlendMode/*=BLEND_Opaque*/) { return default; }
	public bool SetMICTwoSided_EditorOnly(UObject Material,bool TwoSided/*=false*/) { return default; }
	public bool SetMICIsThinSurface_EditorOnly(UObject Material,bool bIsThinSurface/*=false*/) { return default; }
	public bool SetMICDitheredLODTransition_EditorOnly(UObject Material,bool DitheredLODTransition/*=false*/) { return default; }
}

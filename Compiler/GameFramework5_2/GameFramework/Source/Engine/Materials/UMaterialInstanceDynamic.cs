#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstanceDynamic.h")]
public partial class UMaterialInstanceDynamic : UMaterialInstance {
// MaterialInstanceDynamic
	public  void SetScalarParameterValue(string ParameterName,float Value) {}
	public  void SetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo,float Value) {}
	public  bool InitializeScalarParameterAndGetIndex(string ParameterName,float Value,int OutParameterIndex) { return default; }
	public  bool SetScalarParameterByIndex(int ParameterIndex,float Value) { return default; }
	public  float K2_GetScalarParameterValue(string ParameterName) { return default; }
	public  float K2_GetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo) { return default; }
	public  void SetTextureParameterValue(string ParameterName,UTexture Value) {}
	public  void SetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo,UTexture Value) {}
	public  void SetRuntimeVirtualTextureParameterValue(string ParameterName,URuntimeVirtualTexture Value) {}
	public  void SetRuntimeVirtualTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo,URuntimeVirtualTexture Value) {}
	public  void SetSparseVolumeTextureParameterValue(string ParameterName,USparseVolumeTexture Value) {}
	public  UTexture K2_GetTextureParameterValue(string ParameterName) { return default; }
	public  UTexture K2_GetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo) { return default; }
	public  void SetVectorParameterValue(string ParameterName,FLinearColor Value) {}
	public  void SetDoubleVectorParameterValue(string ParameterName,FVector4 Value) {}
	public  void SetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo,FLinearColor Value) {}
	public  FLinearColor K2_GetVectorParameterValue(string ParameterName) { return default; }
	public  FLinearColor K2_GetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo) { return default; }
	public  void K2_InterpolateMaterialInstanceParams(UMaterialInstance SourceA,UMaterialInstance SourceB,float Alpha) {}
	public  void K2_CopyMaterialInstanceParameters(UMaterialInterface Source,bool bQuickParametersOnly/*=false*/) {}
	public  void CopyInterpParameters(UMaterialInstance Source) {}
	public  void CopyParameterOverrides(UMaterialInstance MaterialInstance) {}
}

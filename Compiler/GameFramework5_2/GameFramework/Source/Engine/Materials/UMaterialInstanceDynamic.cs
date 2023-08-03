#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstanceDynamic.h")]
public partial class UMaterialInstanceDynamic : UMaterialInstance {
	public static UClass StaticClass() {return default;}
	///<summary>Set a MID scalar (float) parameter value</summary>
	public  void SetScalarParameterValue(string ParameterName,float Value) {}
	///<summary>Set a MID scalar (float) parameter value using MPI (to allow access to layer parameters)</summary>
	public  void SetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo,float Value) {}
	///<summary>Use this function to set an initial value and fetch the index for use in SetScalarParameterByIndex.  This</summary>
	public  bool InitializeScalarParameterAndGetIndex(string ParameterName,float Value,int OutParameterIndex) { return default; }
	///<summary>Use the cached value of OutParameterIndex from InitializeScalarParameterAndGetIndex to set the scalar parameter</summary>
	public  bool SetScalarParameterByIndex(int ParameterIndex,float Value) { return default; }
	///<summary>Get the current scalar (float) parameter value from an MID</summary>
	public  float K2_GetScalarParameterValue(string ParameterName) { return default; }
	///<summary>Get the current scalar (float) parameter value from an MID, using MPI (to allow access to layer parameters)</summary>
	public  float K2_GetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo) { return default; }
	///<summary>Set an MID texture parameter value</summary>
	public  void SetTextureParameterValue(string ParameterName,UTexture Value) {}
	///<summary>Set an MID texture parameter value using MPI (to allow access to layer parameters)</summary>
	public  void SetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo,UTexture Value) {}
	///<summary>Set an MID texture parameter value</summary>
	public  void SetRuntimeVirtualTextureParameterValue(string ParameterName,URuntimeVirtualTexture Value) {}
	///<summary>Set an MID texture parameter value using MPI (to allow access to layer parameters)</summary>
	public  void SetRuntimeVirtualTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo,URuntimeVirtualTexture Value) {}
	///<summary>Set an MID texture parameter value</summary>
	public  void SetSparseVolumeTextureParameterValue(string ParameterName,USparseVolumeTexture Value) {}
	///<summary>Get the current MID texture parameter value</summary>
	public  UTexture K2_GetTextureParameterValue(string ParameterName) { return default; }
	///<summary>Get the current MID texture parameter value, using MPI (to allow access to layer parameters)</summary>
	public  UTexture K2_GetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo) { return default; }
	///<summary>Set an MID vector parameter value</summary>
	public  void SetVectorParameterValue(string ParameterName,FLinearColor Value) {}
	///<summary>Set an MID vector parameter value</summary>
	public  void SetDoubleVectorParameterValue(string ParameterName,FVector4 Value) {}
	///<summary>Set an MID vector parameter value, using MPI (to allow access to layer parameters)</summary>
	public  void SetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo,FLinearColor Value) {}
	///<summary>Get the current MID vector parameter value</summary>
	public  FLinearColor K2_GetVectorParameterValue(string ParameterName) { return default; }
	///<summary>Get the current MID vector parameter value, using MPI (to allow access to layer parameters)</summary>
	public  FLinearColor K2_GetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo) { return default; }
	///<summary>Interpolates the scalar and vector parameters of this material instance based on two other material instances, and an alpha blending factor</summary>
	public  void K2_InterpolateMaterialInstanceParams(UMaterialInstance SourceA,UMaterialInstance SourceB,float Alpha) {}
	///<summary>Copies over parameters given a material interface (copy each instance following the hierarchy)</summary>
	public  void K2_CopyMaterialInstanceParameters(UMaterialInterface Source,bool bQuickParametersOnly/*=false*/) {}
	///<summary>Copies over parameters given a material instance (only copy from the instance, not following the hierarchy)</summary>
	public  void CopyInterpParameters(UMaterialInstance Source) {}
	///<summary>Copy parameter values from another material instance. This will copy only</summary>
	public  void CopyParameterOverrides(UMaterialInstance MaterialInstance) {}
}

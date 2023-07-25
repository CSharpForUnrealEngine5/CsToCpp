#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMaterialLibrary.h")]
public partial class UKismetMaterialLibrary : UBlueprintFunctionLibrary {
// KismetMaterialLibrary
	public void SetScalarParameterValue(UObject WorldContextObject,UObject Collection,string ParameterName,float ParameterValue) {}
	public void SetVectorParameterValue(UObject WorldContextObject,UObject Collection,string ParameterName,FLinearColor ParameterValue) {}
	public float GetScalarParameterValue(UObject WorldContextObject,UObject Collection,string ParameterName) { return default; }
	public FLinearColor GetVectorParameterValue(UObject WorldContextObject,UObject Collection,string ParameterName) { return default; }
	public UObject CreateDynamicMaterialInstance(UObject WorldContextObject,UObject Parent,string OptionalName/*=NAME_None*/,EMIDCreationFlags CreationFlags/*=EMIDCreationFlags.None*/) { return default; }
}

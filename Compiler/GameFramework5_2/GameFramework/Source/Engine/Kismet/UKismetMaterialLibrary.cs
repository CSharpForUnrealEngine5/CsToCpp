#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMaterialLibrary.h")]
public partial class UKismetMaterialLibrary : UBlueprintFunctionLibrary {
// KismetMaterialLibrary
	public static void SetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName,float ParameterValue) {}
	public static void SetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName,FLinearColor ParameterValue) {}
	public static float GetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName) { return default; }
	public static FLinearColor GetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName) { return default; }
	public static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject,UMaterialInterface Parent,string OptionalName/*=NAME_None*/,EMIDCreationFlags CreationFlags/*=EMIDCreationFlags.None*/) { return default; }
}

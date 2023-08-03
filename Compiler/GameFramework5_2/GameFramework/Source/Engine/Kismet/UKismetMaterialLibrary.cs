#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMaterialLibrary.h")]
public partial class UKismetMaterialLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Sets a scalar parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
	public static void SetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName,float ParameterValue) {}
	///<summary>Sets a vector parameter value on the material collection instance. Logs if ParameterName is invalid.</summary>
	public static void SetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName,FLinearColor ParameterValue) {}
	///<summary>Gets a scalar parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
	public static float GetScalarParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName) { return default; }
	///<summary>Gets a vector parameter value from the material collection instance. Logs if ParameterName is invalid.</summary>
	public static FLinearColor GetVectorParameterValue(UObject WorldContextObject,UMaterialParameterCollection Collection,string ParameterName) { return default; }
	///<summary>Creates a Dynamic Material Instance which you can modify during gameplay.</summary>
	public static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject,UMaterialInterface Parent,string OptionalName/*=NAME_None*/,EMIDCreationFlags CreationFlags/*=EMIDCreationFlags.None*/) { return default; }
}

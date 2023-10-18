namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helpers to dynamically set parameters on graph instances.</summary>
[CppInclude("Helpers/PCGGraphParametersHelpers.h")]
public partial class UPCGGraphParametersHelpers : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>IsOverridden</summary>
	public static bool IsOverridden(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>Getters</summary>
	public static float GetFloatParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetDoubleParameter</summary>
	public static double GetDoubleParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetBoolParameter</summary>
	public static bool GetBoolParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetByteParameter</summary>
	public static byte GetByteParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetInt32Parameter</summary>
	public static int GetInt32Parameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetInt64Parameter</summary>
	public static long GetInt64Parameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetNameParameter</summary>
	public static FName GetNameParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetStringParameter</summary>
	public static string GetStringParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetSoftObjectParameter</summary>
	public static TSoftObjectPtr<UObject> GetSoftObjectParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetSoftClassParameter</summary>
	public static TSoftObjectPtr<UClass> GetSoftClassParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetVectorParameter</summary>
	public static FVector GetVectorParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetRotatorParameter</summary>
	public static FRotator GetRotatorParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>GetTransformParameter</summary>
	public static FTransform GetTransformParameter(UPCGGraphInstance GraphInstance,FName Name) { return default; }
	///<summary>Setters</summary>
	public static void SetFloatParameter(UPCGGraphInstance GraphInstance,FName Name,float Value) {}
	///<summary>SetDoubleParameter</summary>
	public static void SetDoubleParameter(UPCGGraphInstance GraphInstance,FName Name,double Value) {}
	///<summary>SetBoolParameter</summary>
	public static void SetBoolParameter(UPCGGraphInstance GraphInstance,FName Name,bool bValue) {}
	///<summary>SetByteParameter</summary>
	public static void SetByteParameter(UPCGGraphInstance GraphInstance,FName Name,byte Value) {}
	///<summary>SetInt32Parameter</summary>
	public static void SetInt32Parameter(UPCGGraphInstance GraphInstance,FName Name,int Value) {}
	///<summary>SetInt64Parameter</summary>
	public static void SetInt64Parameter(UPCGGraphInstance GraphInstance,FName Name,long Value) {}
	///<summary>SetNameParameter</summary>
	public static void SetNameParameter(UPCGGraphInstance GraphInstance,FName Name,FName Value) {}
	///<summary>SetStringParameter</summary>
	public static void SetStringParameter(UPCGGraphInstance GraphInstance,FName Name,string Value) {}
	///<summary>SetEnumParameter</summary>
	public static void SetEnumParameter(UPCGGraphInstance GraphInstance,FName Name,UEnum Enum,byte Value) {}
	///<summary>SetSoftObjectParameter</summary>
	public static void SetSoftObjectParameter(UPCGGraphInstance GraphInstance,FName Name,TSoftObjectPtr<UObject> Value) {}
	///<summary>SetSoftClassParameter</summary>
	public static void SetSoftClassParameter(UPCGGraphInstance GraphInstance,FName Name,TSoftObjectPtr<UClass> Value) {}
	///<summary>SetVectorParameter</summary>
	public static void SetVectorParameter(UPCGGraphInstance GraphInstance,FName Name,FVector Value) {}
	///<summary>SetRotatorParameter</summary>
	public static void SetRotatorParameter(UPCGGraphInstance GraphInstance,FName Name,FRotator Value) {}
	///<summary>SetTransformParameter</summary>
	public static void SetTransformParameter(UPCGGraphInstance GraphInstance,FName Name,FTransform Value) {}
}

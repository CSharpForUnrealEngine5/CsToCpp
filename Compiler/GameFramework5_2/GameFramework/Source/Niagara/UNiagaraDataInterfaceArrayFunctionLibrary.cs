#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>C++ and Blueprint library for accessing array types</summary>
[CppInclude("NiagaraDataInterfaceArrayFunctionLibrary.h")]
public partial class UNiagaraDataInterfaceArrayFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>Sets Niagara Array Float Data.</summary>
	public static void SetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<float> ArrayData) {}
	///<summary>Sets Niagara Array FVector2D Data.</summary>
	public static void SetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<FVector2D> ArrayData) {}
	///<summary>Sets Niagara Array FVector Data.</summary>
	public static void SetNiagaraArrayVector(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<FVector> ArrayData) {}
	///<summary>Sets Niagara Array FVector Data.</summary>
	public static void SetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<FVector> ArrayData) {}
	///<summary>Sets Niagara Array FVector4 Data.</summary>
	public static void SetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<FVector4> ArrayData) {}
	///<summary>Sets Niagara Array FLinearColor Data.</summary>
	public static void SetNiagaraArrayColor(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<FLinearColor> ArrayData) {}
	///<summary>Sets Niagara Array FQuat Data.</summary>
	public static void SetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<FQuat> ArrayData) {}
	///<summary>Sets Niagara Array Int32 Data.</summary>
	public static void SetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<int> ArrayData) {}
	///<summary>Sets Niagara Array UInt8 Data.</summary>
	public static void SetNiagaraArrayUInt8(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<int> ArrayData) {}
	///<summary>Sets Niagara Array Bool Data.</summary>
	public static void SetNiagaraArrayBool(UNiagaraComponent NiagaraSystem,string OverrideName,TArray<bool> ArrayData) {}
	///<summary>Gets a copy of Niagara Float Data.</summary>
	public static TArray<float> GetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FVector2D Data.</summary>
	public static TArray<FVector2D> GetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FVector Data.</summary>
	public static TArray<FVector> GetNiagaraArrayVector(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara Position Data.</summary>
	public static TArray<FVector> GetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FVector4 Data.</summary>
	public static TArray<FVector4> GetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FLinearColor Data.</summary>
	public static TArray<FLinearColor> GetNiagaraArrayColor(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FQuat Data.</summary>
	public static TArray<FQuat> GetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara Int32 Data.</summary>
	public static TArray<int> GetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara UInt8 Data.</summary>
	public static TArray<int> GetNiagaraArrayUInt8(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Gets a copy of Niagara Bool Data.</summary>
	public static TArray<bool> GetNiagaraArrayBool(UNiagaraComponent NiagaraSystem,string OverrideName) { return default; }
	///<summary>Sets a single value within a Niagara Array Float.</summary>
	public static void SetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,float Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FVector2D.</summary>
	public static void SetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,FVector2D Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FVector.</summary>
	public static void SetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,FVector Value,bool bSizeToFit) {}
	///<summary>SetNiagaraArrayPositionValue</summary>
	public static void SetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,FVector Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FVector4.</summary>
	public static void SetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,FVector4 Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FLinearColor.</summary>
	public static void SetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,FLinearColor Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FQuat.</summary>
	public static void SetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,FQuat Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array Int32.</summary>
	public static void SetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,int Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array UInt8.</summary>
	public static void SetNiagaraArrayUInt8Value(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,int Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array Bool.</summary>
	public static void SetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index,bool Value,bool bSizeToFit) {}
	///<summary>Gets a single value within a Niagara Array Float.</summary>
	public static float GetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FVector2D.</summary>
	public static FVector2D GetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FVector.</summary>
	public static FVector GetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array Position.</summary>
	public static FVector GetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FVector4.</summary>
	public static FVector4 GetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FLinearColor.</summary>
	public static FLinearColor GetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FQuat.</summary>
	public static FQuat GetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array Int32.</summary>
	public static int GetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array UInt8.</summary>
	public static int GetNiagaraArrayUInt8Value(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array Bool.</summary>
	public static bool GetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem,string OverrideName,int Index) { return default; }
}

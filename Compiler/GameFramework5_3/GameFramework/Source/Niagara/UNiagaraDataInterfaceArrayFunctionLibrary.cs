namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>C++ and Blueprint library for accessing array types</summary>
[CppInclude("NiagaraDataInterfaceArrayFunctionLibrary.h")]
public partial class UNiagaraDataInterfaceArrayFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Sets Niagara Array Float Data.</summary>
	public static void SetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<float> ArrayData) {}
	///<summary>Sets Niagara Array FVector2D Data.</summary>
	public static void SetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<FVector2D> ArrayData) {}
	///<summary>Sets Niagara Array FVector Data.</summary>
	public static void SetNiagaraArrayVector(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<FVector> ArrayData) {}
	///<summary>Sets Niagara Array FVector Data.</summary>
	public static void SetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<FVector> ArrayData) {}
	///<summary>Sets Niagara Array FVector4 Data.</summary>
	public static void SetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<FVector4> ArrayData) {}
	///<summary>Sets Niagara Array FLinearColor Data.</summary>
	public static void SetNiagaraArrayColor(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<FLinearColor> ArrayData) {}
	///<summary>Sets Niagara Array FQuat Data.</summary>
	public static void SetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<FQuat> ArrayData) {}
	///<summary>Sets Niagara Array FMatrix Data.</summary>
	public static void SetNiagaraArrayMatrix(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<FMatrix> ArrayData,bool bApplyLWCRebase/*=true*/) {}
	///<summary>Sets Niagara Array Int32 Data.</summary>
	public static void SetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<int> ArrayData) {}
	///<summary>Sets Niagara Array UInt8 Data.</summary>
	public static void SetNiagaraArrayUInt8(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<int> ArrayData) {}
	///<summary>Sets Niagara Array Bool Data.</summary>
	public static void SetNiagaraArrayBool(UNiagaraComponent NiagaraSystem,FName OverrideName,TArray<bool> ArrayData) {}
	///<summary>Gets a copy of Niagara Float Data.</summary>
	public static TArray<float> GetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FVector2D Data.</summary>
	public static TArray<FVector2D> GetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FVector Data.</summary>
	public static TArray<FVector> GetNiagaraArrayVector(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara Position Data.</summary>
	public static TArray<FVector> GetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FVector4 Data.</summary>
	public static TArray<FVector4> GetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FLinearColor Data.</summary>
	public static TArray<FLinearColor> GetNiagaraArrayColor(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FQuat Data.</summary>
	public static TArray<FQuat> GetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara FMatrix Data.</summary>
	public static TArray<FMatrix> GetNiagaraArrayMatrix(UNiagaraComponent NiagaraSystem,FName OverrideName,bool bApplyLWCRebase/*=true*/) { return default; }
	///<summary>Gets a copy of Niagara Int32 Data.</summary>
	public static TArray<int> GetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara UInt8 Data.</summary>
	public static TArray<int> GetNiagaraArrayUInt8(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Gets a copy of Niagara Bool Data.</summary>
	public static TArray<bool> GetNiagaraArrayBool(UNiagaraComponent NiagaraSystem,FName OverrideName) { return default; }
	///<summary>Sets a single value within a Niagara Array Float.</summary>
	public static void SetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,float Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FVector2D.</summary>
	public static void SetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,FVector2D Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FVector.</summary>
	public static void SetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,FVector Value,bool bSizeToFit) {}
	///<summary>SetNiagaraArrayPositionValue</summary>
	public static void SetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,FVector Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FVector4.</summary>
	public static void SetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,FVector4 Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FLinearColor.</summary>
	public static void SetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,FLinearColor Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FQuat.</summary>
	public static void SetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,FQuat Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array FMatrix.</summary>
	public static void SetNiagaraArrayMatrixValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,FMatrix Value,bool bSizeToFit,bool bApplyLWCRebase/*=true*/) {}
	///<summary>Sets a single value within a Niagara Array Int32.</summary>
	public static void SetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,int Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array UInt8.</summary>
	public static void SetNiagaraArrayUInt8Value(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,int Value,bool bSizeToFit) {}
	///<summary>Sets a single value within a Niagara Array Bool.</summary>
	public static void SetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,bool Value,bool bSizeToFit) {}
	///<summary>Gets a single value within a Niagara Array Float.</summary>
	public static float GetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FVector2D.</summary>
	public static FVector2D GetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FVector.</summary>
	public static FVector GetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array Position.</summary>
	public static FVector GetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FVector4.</summary>
	public static FVector4 GetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FLinearColor.</summary>
	public static FLinearColor GetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FQuat.</summary>
	public static FQuat GetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array FMatrix.</summary>
	public static FMatrix GetNiagaraArrayMatrixValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index,bool bApplyLWCRebase/*=true*/) { return default; }
	///<summary>Gets a single value within a Niagara Array Int32.</summary>
	public static int GetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array UInt8.</summary>
	public static int GetNiagaraArrayUInt8Value(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
	///<summary>Gets a single value within a Niagara Array Bool.</summary>
	public static bool GetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem,FName OverrideName,int Index) { return default; }
}

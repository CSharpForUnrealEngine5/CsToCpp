#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceArrayFunctionLibrary.h")]
///<summary>C++ and Blueprint library for accessing array types</summary>
public partial class UNiagaraDataInterfaceArrayFunctionLibrary : UBlueprintFunctionLibrary {
// NiagaraDataInterfaceArrayFunctionLibrary
	public void SetNiagaraArrayFloat(UObject NiagaraSystem,string OverrideName,TArray<float> ArrayData) {}
	public void SetNiagaraArrayVector2D(UObject NiagaraSystem,string OverrideName,TArray<FVector2D> ArrayData) {}
	public void SetNiagaraArrayVector(UObject NiagaraSystem,string OverrideName,TArray<FVector> ArrayData) {}
	public void SetNiagaraArrayPosition(UObject NiagaraSystem,string OverrideName,TArray<FVector> ArrayData) {}
	public void SetNiagaraArrayVector4(UObject NiagaraSystem,string OverrideName,TArray<FVector4> ArrayData) {}
	public void SetNiagaraArrayColor(UObject NiagaraSystem,string OverrideName,TArray<FLinearColor> ArrayData) {}
	public void SetNiagaraArrayQuat(UObject NiagaraSystem,string OverrideName,TArray<FQuat> ArrayData) {}
	public void SetNiagaraArrayInt32(UObject NiagaraSystem,string OverrideName,TArray<int> ArrayData) {}
	public void SetNiagaraArrayUInt8(UObject NiagaraSystem,string OverrideName,TArray<int> ArrayData) {}
	public void SetNiagaraArrayBool(UObject NiagaraSystem,string OverrideName,TArray<bool> ArrayData) {}
	public TArray<float> GetNiagaraArrayFloat(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<FVector2D> GetNiagaraArrayVector2D(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<FVector> GetNiagaraArrayVector(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<FVector> GetNiagaraArrayPosition(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<FVector4> GetNiagaraArrayVector4(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<FLinearColor> GetNiagaraArrayColor(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<FQuat> GetNiagaraArrayQuat(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<int> GetNiagaraArrayInt32(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<int> GetNiagaraArrayUInt8(UObject NiagaraSystem,string OverrideName) { return default; }
	public TArray<bool> GetNiagaraArrayBool(UObject NiagaraSystem,string OverrideName) { return default; }
	public void SetNiagaraArrayFloatValue(UObject NiagaraSystem,string OverrideName,int Index,float Value,bool bSizeToFit) {}
	public void SetNiagaraArrayVector2DValue(UObject NiagaraSystem,string OverrideName,int Index,FVector2D Value,bool bSizeToFit) {}
	public void SetNiagaraArrayVectorValue(UObject NiagaraSystem,string OverrideName,int Index,FVector Value,bool bSizeToFit) {}
	public void SetNiagaraArrayPositionValue(UObject NiagaraSystem,string OverrideName,int Index,FVector Value,bool bSizeToFit) {}
	public void SetNiagaraArrayVector4Value(UObject NiagaraSystem,string OverrideName,int Index,FVector4 Value,bool bSizeToFit) {}
	public void SetNiagaraArrayColorValue(UObject NiagaraSystem,string OverrideName,int Index,FLinearColor Value,bool bSizeToFit) {}
	public void SetNiagaraArrayQuatValue(UObject NiagaraSystem,string OverrideName,int Index,FQuat Value,bool bSizeToFit) {}
	public void SetNiagaraArrayInt32Value(UObject NiagaraSystem,string OverrideName,int Index,int Value,bool bSizeToFit) {}
	public void SetNiagaraArrayUInt8Value(UObject NiagaraSystem,string OverrideName,int Index,int Value,bool bSizeToFit) {}
	public void SetNiagaraArrayBoolValue(UObject NiagaraSystem,string OverrideName,int Index,bool Value,bool bSizeToFit) {}
	public float GetNiagaraArrayFloatValue(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public FVector2D GetNiagaraArrayVector2DValue(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public FVector GetNiagaraArrayVectorValue(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public FVector GetNiagaraArrayPositionValue(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public FVector4 GetNiagaraArrayVector4Value(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public FLinearColor GetNiagaraArrayColorValue(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public FQuat GetNiagaraArrayQuatValue(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public int GetNiagaraArrayInt32Value(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public int GetNiagaraArrayUInt8Value(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
	public bool GetNiagaraArrayBoolValue(UObject NiagaraSystem,string OverrideName,int Index) { return default; }
}

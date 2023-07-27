#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterCollection.h")]
public partial class UNiagaraParameterCollectionInstance : UObject {
// NiagaraParameterCollectionInstance
	public UNiagaraParameterCollection Collection;
	public TArray<FNiagaraVariable> OverridenParameters;
	public FNiagaraParameterStore ParameterStorage;
	public  bool GetBoolParameter(string InVariableName) { return default; }
	public  float GetFloatParameter(string InVariableName) { return default; }
	public  int GetIntParameter(string InVariableName) { return default; }
	public  FVector2D GetVector2DParameter(string InVariableName) { return default; }
	public  FVector GetVectorParameter(string InVariableName) { return default; }
	public  FVector4 GetVector4Parameter(string InVariableName) { return default; }
	public  FQuat GetQuatParameter(string InVariableName) { return default; }
	public  FLinearColor GetColorParameter(string InVariableName) { return default; }
	public  void SetBoolParameter(string InVariableName,bool InValue) {}
	public  void SetFloatParameter(string InVariableName,float InValue) {}
	public  void SetIntParameter(string InVariableName,int InValue) {}
	public  void SetVector2DParameter(string InVariableName,FVector2D InValue) {}
	public  void SetVectorParameter(string InVariableName,FVector InValue) {}
	public  void SetVector4Parameter(string InVariableName,FVector4 InValue) {}
	public  void SetColorParameter(string InVariableName,FLinearColor InValue) {}
	public  void SetQuatParameter(string InVariableName,FQuat InValue) {}
}

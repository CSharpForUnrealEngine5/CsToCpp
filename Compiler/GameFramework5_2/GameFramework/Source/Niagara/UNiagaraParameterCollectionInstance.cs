#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterCollection.h")]
public partial class UNiagaraParameterCollectionInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: Abstract to some interface to allow a hierarchy like UMaterialInstance?</summary>
	public UNiagaraParameterCollection Collection;
	///<summary>When editing instances, we must track which parameters are overridden so we can pull in any changes to the default.</summary>
	public TArray<FNiagaraVariable> OverridenParameters;
	///<summary>ParameterStorage</summary>
	public FNiagaraParameterStore ParameterStorage;
	///<summary>Accessors from Blueprint. For now just exposing common types but ideally we can expose any somehow in future.</summary>
	public  bool GetBoolParameter(string InVariableName) { return default; }
	///<summary>GetFloatParameter</summary>
	public  float GetFloatParameter(string InVariableName) { return default; }
	///<summary>GetIntParameter</summary>
	public  int GetIntParameter(string InVariableName) { return default; }
	///<summary>GetVector2DParameter</summary>
	public  FVector2D GetVector2DParameter(string InVariableName) { return default; }
	///<summary>GetVectorParameter</summary>
	public  FVector GetVectorParameter(string InVariableName) { return default; }
	///<summary>GetVector4Parameter</summary>
	public  FVector4 GetVector4Parameter(string InVariableName) { return default; }
	///<summary>GetQuatParameter</summary>
	public  FQuat GetQuatParameter(string InVariableName) { return default; }
	///<summary>GetColorParameter</summary>
	public  FLinearColor GetColorParameter(string InVariableName) { return default; }
	///<summary>SetBoolParameter</summary>
	public  void SetBoolParameter(string InVariableName,bool InValue) {}
	///<summary>SetFloatParameter</summary>
	public  void SetFloatParameter(string InVariableName,float InValue) {}
	///<summary>SetIntParameter</summary>
	public  void SetIntParameter(string InVariableName,int InValue) {}
	///<summary>SetVector2DParameter</summary>
	public  void SetVector2DParameter(string InVariableName,FVector2D InValue) {}
	///<summary>SetVectorParameter</summary>
	public  void SetVectorParameter(string InVariableName,FVector InValue) {}
	///<summary>TODO[mg]: add position setter for LWC</summary>
	public  void SetVector4Parameter(string InVariableName,FVector4 InValue) {}
	///<summary>SetColorParameter</summary>
	public  void SetColorParameter(string InVariableName,FLinearColor InValue) {}
	///<summary>SetQuatParameter</summary>
	public  void SetQuatParameter(string InVariableName,FQuat InValue) {}
}

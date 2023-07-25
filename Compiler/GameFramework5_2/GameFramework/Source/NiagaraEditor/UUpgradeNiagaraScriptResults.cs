#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpgradeNiagaraScriptResults.h")]
///<summary>Wrapper class for passing results back from the version upgrade python script.</summary>
public partial class UUpgradeNiagaraScriptResults : UObject {
// UpgradeNiagaraScriptResults
	public bool bCancelledByPythonError;
	public TArray<UNiagaraPythonScriptModuleInput> OldInputs;
	public TArray<UNiagaraPythonScriptModuleInput> NewInputs;
	public UObject GetOldInput(string InputName) { return default; }
	public void SetFloatInput(string InputName,float Value) {}
	public void SetIntInput(string InputName,int Value) {}
	public void SetBoolInput(string InputName,bool Value) {}
	public void SetVec2Input(string InputName,FVector2D Value) {}
	public void SetVec3Input(string InputName,FVector Value) {}
	public void SetVec4Input(string InputName,FVector4 Value) {}
	public void SetColorInput(string InputName,FLinearColor Value) {}
	public void SetQuatInput(string InputName,FQuat Value) {}
	public void SetEnumInput(string InputName,string Value) {}
	public void SetLinkedInput(string InputName,string Value) {}
	public UNiagaraPythonScriptModuleInput DummyInput;
}

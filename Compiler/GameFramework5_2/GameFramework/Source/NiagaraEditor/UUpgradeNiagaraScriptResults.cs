namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper class for passing results back from the version upgrade python script.</summary>
[CppInclude("UpgradeNiagaraScriptResults.h")]
public partial class UUpgradeNiagaraScriptResults : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the converter process was cancelled due to an unrecoverable error in the python script process.</summary>
	public bool bCancelledByPythonError;
	///<summary>OldInputs</summary>
	public TArray<UNiagaraPythonScriptModuleInput> OldInputs;
	///<summary>NewInputs</summary>
	public TArray<UNiagaraPythonScriptModuleInput> NewInputs;
	///<summary>GetOldInput</summary>
	public UNiagaraPythonScriptModuleInput GetOldInput(string InputName) { return default; }
	///<summary>SetFloatInput</summary>
	public void SetFloatInput(string InputName,float Value) {}
	///<summary>SetIntInput</summary>
	public void SetIntInput(string InputName,int Value) {}
	///<summary>SetBoolInput</summary>
	public void SetBoolInput(string InputName,bool Value) {}
	///<summary>SetVec2Input</summary>
	public void SetVec2Input(string InputName,FVector2D Value) {}
	///<summary>SetVec3Input</summary>
	public void SetVec3Input(string InputName,FVector Value) {}
	///<summary>SetVec4Input</summary>
	public void SetVec4Input(string InputName,FVector4 Value) {}
	///<summary>SetColorInput</summary>
	public void SetColorInput(string InputName,FLinearColor Value) {}
	///<summary>SetQuatInput</summary>
	public void SetQuatInput(string InputName,FQuat Value) {}
	///<summary>SetEnumInput</summary>
	public void SetEnumInput(string InputName,string Value) {}
	///<summary>SetLinkedInput</summary>
	public void SetLinkedInput(string InputName,string Value) {}
	///<summary>This is used as a placeholder object for python to interact with when a module input could not be found. Returning a nullptr instead would crash the script.</summary>
	public UNiagaraPythonScriptModuleInput DummyInput;
}

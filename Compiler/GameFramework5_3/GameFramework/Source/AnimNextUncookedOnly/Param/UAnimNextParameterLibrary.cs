namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a single parameter</summary>
[CppInclude("Param/AnimNextParameterLibrary.h")]
public partial class UAnimNextParameterLibrary : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AddParameter</summary>
	public UAnimNextParameter AddParameter(FName InName,EPropertyBagPropertyType InValueType,EPropertyBagContainerType InContainerType,UObject InValueTypeObject/*=nullptr*/,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>RemoveParameter</summary>
	public bool RemoveParameter(FName InName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>RemoveParameters</summary>
	public bool RemoveParameters(TArray<FName> InNames,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>FindParameter</summary>
	public UAnimNextParameter FindParameter(FName InName) { return default; }
	///<summary>Comment to display in editor</summary>
	public string Comment;
	///<summary>All parameters contained in this library - not saved, discovered at load time</summary>
	public TArray<UAnimNextParameter> Parameters;
}

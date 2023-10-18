namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script-callable editor API hoisted onto UAnimNextParameterBlock</summary>
[CppInclude("Param/AnimNextParameterBlock_EditorData.h")]
public partial class UAnimNextParameterBlockLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>AddBinding</summary>
	public static UAnimNextParameterBlockBinding AddBinding(UAnimNextParameterBlock InBlock,FName InName,UAnimNextParameterLibrary InLibrary,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>AddBindingReference</summary>
	public static UAnimNextParameterBlockBindingReference AddBindingReference(UAnimNextParameterBlock InBlock,FName InName,UAnimNextParameterLibrary InLibrary,UAnimNextParameterBlock InReferencedBlock,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>RemoveAllBindings</summary>
	public static bool RemoveAllBindings(UAnimNextParameterBlock InBlock,FName InName,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>RemoveEntry</summary>
	public static bool RemoveEntry(UAnimNextParameterBlock InBlock,UAnimNextParameterBlockEntry InEntry,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>RemoveEntries</summary>
	public static bool RemoveEntries(UAnimNextParameterBlock InBlock,TArray<UAnimNextParameterBlockEntry> InEntries,bool bSetupUndoRedo/*=true*/,bool bPrintPythonCommand/*=true*/) { return default; }
	///<summary>FindBinding</summary>
	public static UAnimNextParameterBlockEntry FindBinding(UAnimNextParameterBlock InBlock,FName InName) { return default; }
}

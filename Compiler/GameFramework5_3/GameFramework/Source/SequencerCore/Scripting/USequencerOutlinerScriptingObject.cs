namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Scripting/OutlinerScriptingObject.h")]
public partial class USequencerOutlinerScriptingObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OnSelectionChanged</summary>
	public FSequencerOutlinerSelectionChanged OnSelectionChanged;
	///<summary>GetRootNode</summary>
	public FSequencerViewModelScriptingStruct GetRootNode() { return default; }
	///<summary>GetChildren</summary>
	public TArray<FSequencerViewModelScriptingStruct> GetChildren(FSequencerViewModelScriptingStruct Node,FName TypeName/*=NAME_None*/) { return default; }
	///<summary>GetSelection</summary>
	public TArray<FSequencerViewModelScriptingStruct> GetSelection() { return default; }
	///<summary>SetSelection</summary>
	public void SetSelection(TArray<FSequencerViewModelScriptingStruct> InSelection) {}
}

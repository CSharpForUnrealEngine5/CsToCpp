#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorFilterLibrary.h")]
///<summary>Utility class to filter a list of objects. Object should be in the World Editor.</summary>
public partial class UEditorFilterLibrary : UBlueprintFunctionLibrary {
// EditorFilterLibrary
	public TArray<UObject> ByClass(TArray<UObject> TargetArray,UClass ObjectClass,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public TArray<UObject> ByIDName(TArray<UObject> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public TArray<UObject> ByActorLabel(TArray<UObject> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/,bool bIgnoreCase/*=true*/) { return default; }
	public TArray<UObject> ByActorTag(TArray<UObject> TargetArray,string Tag,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public TArray<UObject> ByLayer(TArray<UObject> TargetArray,string LayerName,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public TArray<UObject> ByLevelName(TArray<UObject> TargetArray,string LevelName,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public TArray<UObject> BySelection(TArray<UObject> TargetArray,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
}

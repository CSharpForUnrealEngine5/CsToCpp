#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorFilterLibrary.h")]
///<summary>Utility class to filter a list of objects. Object should be in the World Editor.</summary>
public partial class UEditorFilterLibrary : UBlueprintFunctionLibrary {
// EditorFilterLibrary
	public static TArray<UObject> ByClass(TArray<UObject> TargetArray,UClass ObjectClass,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public static TArray<UObject> ByIDName(TArray<UObject> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public static TArray<AActor> ByActorLabel(TArray<AActor> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/,bool bIgnoreCase/*=true*/) { return default; }
	public static TArray<AActor> ByActorTag(TArray<AActor> TargetArray,string Tag,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public static TArray<AActor> ByLayer(TArray<AActor> TargetArray,string LayerName,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public static TArray<AActor> ByLevelName(TArray<AActor> TargetArray,string LevelName,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	public static TArray<AActor> BySelection(TArray<AActor> TargetArray,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
}

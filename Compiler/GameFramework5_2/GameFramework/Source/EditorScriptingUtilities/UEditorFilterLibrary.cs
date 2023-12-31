namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Utility class to filter a list of objects. Object should be in the World Editor.</summary>
[CppInclude("EditorFilterLibrary.h")]
public partial class UEditorFilterLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Filter the array based on the Object&#39;s class.</summary>
	public static TArray<UObject> ByClass(TArray<UObject> TargetArray,UClass ObjectClass,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	///<summary>Filter the array based on the Object&#39;s ID name.</summary>
	public static TArray<UObject> ByIDName(TArray<UObject> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	///<summary>Filter the array based on the Actor&#39;s label (what we see in the editor)</summary>
	public static TArray<AActor> ByActorLabel(TArray<AActor> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/,bool bIgnoreCase/*=true*/) { return default; }
	///<summary>Filter the array by Tag the Actor contains</summary>
	public static TArray<AActor> ByActorTag(TArray<AActor> TargetArray,FName Tag,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	///<summary>Filter the array by Layer the Actor belongs to.</summary>
	public static TArray<AActor> ByLayer(TArray<AActor> TargetArray,FName LayerName,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	///<summary>Filter the array by Level the Actor belongs to.</summary>
	public static TArray<AActor> ByLevelName(TArray<AActor> TargetArray,FName LevelName,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
	///<summary>Filter the array based on Object&#39;s selection.</summary>
	public static TArray<AActor> BySelection(TArray<AActor> TargetArray,EEditorScriptingFilterType FilterType/*=EEditorScriptingFilterType.Include*/) { return default; }
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepFilterLibrary.h")]
public partial class UDataprepFilterLibrary : UBlueprintFunctionLibrary {
	///<summary>Filter the array based on the Object&#39;s class.</summary>
	public static TArray<UObject> FilterByClass(TArray<UObject> TargetArray,UClass ObjectClass) { return default; }
	///<summary>Filter the array based on the Object name.</summary>
	public static TArray<UObject> FilterByName(TArray<UObject> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/) { return default; }
	///<summary>Filter the array based on the geometry size.</summary>
	public static TArray<UObject> FilterBySize(TArray<UObject> TargetArray,EDataprepSizeSource SizeSource,EDataprepSizeFilterMode FilterMode,float Threshold) { return default; }
	///<summary>Filter the array based on a tag.</summary>
	public static TArray<AActor> FilterByTag(TArray<AActor> TargetArray,string Tag) { return default; }
}

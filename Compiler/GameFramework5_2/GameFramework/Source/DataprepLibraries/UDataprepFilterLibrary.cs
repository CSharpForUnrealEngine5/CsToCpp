#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepFilterLibrary.h")]
public partial class UDataprepFilterLibrary : UBlueprintFunctionLibrary {
// DataprepFilterLibrary
	public static TArray<UObject> FilterByClass(TArray<UObject> TargetArray,UClass ObjectClass) { return default; }
	public static TArray<UObject> FilterByName(TArray<UObject> TargetArray,string NameSubString,EEditorScriptingStringMatchType StringMatch/*=EEditorScriptingStringMatchType.Contains*/) { return default; }
	public static TArray<UObject> FilterBySize(TArray<UObject> TargetArray,EDataprepSizeSource SizeSource,EDataprepSizeFilterMode FilterMode,float Threshold) { return default; }
	public static TArray<AActor> FilterByTag(TArray<AActor> TargetArray,string Tag) { return default; }
}

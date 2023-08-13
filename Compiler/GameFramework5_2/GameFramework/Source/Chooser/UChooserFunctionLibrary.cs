namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Morpheus Extensions Function Library</summary>
[CppInclude("ChooserFunctionLibrary.h")]
public partial class UChooserFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Evaluate a chooser table and return the selected UObject, or null</summary>
	public static UObject EvaluateChooser(UObject ContextObject,UChooserTable ChooserTable) { return default; }
	///<summary>Evaluate a chooser table and return the list of all selected UObjects</summary>
	public static TArray<UObject> EvaluateChooserMulti(UObject ContextObject,UChooserTable ChooserTable) { return default; }
}

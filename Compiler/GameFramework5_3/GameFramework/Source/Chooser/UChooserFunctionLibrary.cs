namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Chooser Function Library</summary>
[CppInclude("ChooserFunctionLibrary.h")]
public partial class UChooserFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Evaluate a chooser table and return the selected UObject, or null</summary>
	public static UObject EvaluateChooser(UObject ContextObject,UChooserTable ChooserTable,UClass ObjectClass) { return default; }
	///<summary>Evaluate a chooser table and return the list of all selected UObjects</summary>
	public static TArray<UObject> EvaluateChooserMulti(UObject ContextObject,UChooserTable ChooserTable,UClass ObjectClass) { return default; }
	///<summary>Evaluate an ObjectChooserBase and return the selected UObject, or null</summary>
	public static UObject EvaluateObjectChooserBase(FChooserEvaluationContext Context,FInstancedStruct ObjectChooser,UClass ObjectClass,bool bResultIsClass/*=false*/) { return default; }
	///<summary>Evaluate a chooser table and return all selected UObjects</summary>
	public static TArray<UObject> EvaluateObjectChooserBaseMulti(FChooserEvaluationContext Context,FInstancedStruct ObjectChooser,UClass ObjectClass,bool bResultIsClass/*=false*/) { return default; }
	///<summary>Add an Object to a ChooserEvaluation context</summary>
	public static void AddChooserObjectInput(FChooserEvaluationContext Context,UObject Object) {}
	///<summary>Add a Struct to a ChooserEvaluation context</summary>
	public static void AddChooserStructInput(FChooserEvaluationContext Context,int Value) {}
	///<summary>Get a Struct to a ChooserEvaluation context</summary>
	public static void GetChooserStructOutput(FChooserEvaluationContext Context,int Index,int Value) {}
	///<summary>Create an EvaluateChooser struct</summary>
	public static FInstancedStruct MakeEvaluateChooser(UChooserTable Chooser) { return default; }
	///<summary>MakeChooserEvaluationContext</summary>
	public static FChooserEvaluationContext MakeChooserEvaluationContext() { return default; }
}

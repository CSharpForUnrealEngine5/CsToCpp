namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/DataflowBlueprintLibrary.h")]
public partial class UDataflowBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Find a specific terminal node by name evaluate it using a specific UObject</summary>
	public static void EvaluateTerminalNodeByName(UDataflow Dataflow,string TerminalNodeName,UObject ResultAsset) {}
}

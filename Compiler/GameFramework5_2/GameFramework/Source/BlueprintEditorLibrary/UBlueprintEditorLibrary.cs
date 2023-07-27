#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEditorLibrary.h")]
public partial class UBlueprintEditorLibrary : UBlueprintFunctionLibrary {
// BlueprintEditorLibrary
	public static void ReplaceVariableReferences(UBlueprint Blueprint,string OldVarName,string NewVarName) {}
	public static UEdGraph FindEventGraph(UBlueprint Blueprint) { return default; }
	public static UEdGraph FindGraph(UBlueprint Blueprint,string GraphName) { return default; }
	public static void UpgradeOperatorNodes(UBlueprint Blueprint) {}
	public static void CompileBlueprint(UBlueprint Blueprint) {}
	public static UEdGraph AddFunctionGraph(UBlueprint Blueprint,string FuncName/*=new FString(TEXT("NewFunction"))*/) { return default; }
	public static void RemoveFunctionGraph(UBlueprint Blueprint,string FuncName) {}
	public static void RemoveUnusedNodes(UBlueprint Blueprint) {}
	public static void RemoveGraph(UBlueprint Blueprint,UEdGraph Graph) {}
	public static void RenameGraph(UEdGraph Graph,string NewNameStr/*=new FString(TEXT("NewGraph"))*/) {}
	public static UBlueprint GetBlueprintAsset(UObject Object) { return default; }
	public static void RefreshOpenEditorsForBlueprint(UBlueprint BP) {}
	public static void RefreshAllOpenBlueprintEditors() {}
	public static void ReparentBlueprint(UBlueprint Blueprint,UClass NewParentClass) {}
	public static int RemoveUnusedVariables(UBlueprint Blueprint) { return default; }
	public static UClass GeneratedClass(UBlueprint BlueprintObj) { return default; }
	public static void SetBlueprintVariableExposeOnSpawn(UBlueprint Blueprint,string VariableName,bool bExposeOnSpawn) {}
	public static void SetBlueprintVariableExposeToCinematics(UBlueprint Blueprint,string VariableName,bool bExposeToCinematics) {}
	public static void SetBlueprintVariableInstanceEditable(UBlueprint Blueprint,string VariableName,bool bInstanceEditable) {}
}

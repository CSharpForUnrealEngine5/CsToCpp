#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEditorLibrary.h")]
public partial class UBlueprintEditorLibrary : UBlueprintFunctionLibrary {
// BlueprintEditorLibrary
	public void ReplaceVariableReferences(UObject Blueprint,string OldVarName,string NewVarName) {}
	public UObject FindEventGraph(UObject Blueprint) { return default; }
	public UObject FindGraph(UObject Blueprint,string GraphName) { return default; }
	public void UpgradeOperatorNodes(UObject Blueprint) {}
	public void CompileBlueprint(UObject Blueprint) {}
	public UObject AddFunctionGraph(UObject Blueprint,string FuncName/*=new FString(TEXT("NewFunction"))*/) { return default; }
	public void RemoveFunctionGraph(UObject Blueprint,string FuncName) {}
	public void RemoveUnusedNodes(UObject Blueprint) {}
	public void RemoveGraph(UObject Blueprint,UObject Graph) {}
	public void RenameGraph(UObject Graph,string NewNameStr/*=new FString(TEXT("NewGraph"))*/) {}
	public UObject GetBlueprintAsset(UObject Object) { return default; }
	public void RefreshOpenEditorsForBlueprint(UObject BP) {}
	public void RefreshAllOpenBlueprintEditors() {}
	public void ReparentBlueprint(UObject Blueprint,UClass NewParentClass) {}
	public int RemoveUnusedVariables(UObject Blueprint) { return default; }
	public UClass GeneratedClass(UObject BlueprintObj) { return default; }
	public void SetBlueprintVariableExposeOnSpawn(UObject Blueprint,string VariableName,bool bExposeOnSpawn) {}
	public void SetBlueprintVariableExposeToCinematics(UObject Blueprint,string VariableName,bool bExposeToCinematics) {}
	public void SetBlueprintVariableInstanceEditable(UObject Blueprint,string VariableName,bool bInstanceEditable) {}
}

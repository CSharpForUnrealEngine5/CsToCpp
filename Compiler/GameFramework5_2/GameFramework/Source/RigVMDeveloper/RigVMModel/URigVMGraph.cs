#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMGraph.h")]
///<summary>The Graph represents a Function definition</summary>
public partial class URigVMGraph : UObject {
// RigVMGraph
	public TArray<UObject> GetNodes() { return default; }
	public TArray<UObject> GetLinks() { return default; }
	public TArray<UObject> GetContainedGraphs(bool bRecursive/*=false*/) { return default; }
	public UObject GetParentGraph() { return default; }
	public UObject GetRootGraph() { return default; }
	public bool IsRootGraph() { return default; }
	public UObject GetEntryNode() { return default; }
	public UObject GetReturnNode() { return default; }
	public TArray<FRigVMGraphVariableDescription> GetVariableDescriptions() { return default; }
	public string GetNodePath() { return default; }
	public string GetGraphName() { return default; }
	public UObject FindNodeByName(string InNodeName) { return default; }
	public UObject FindNode(string InNodePath) { return default; }
	public UObject FindPin(string InPinPath) { return default; }
	public UObject FindLink(string InLinkPinPathRepresentation) { return default; }
	public bool IsNodeSelected(string InNodeName) { return default; }
	public TArray<string> GetSelectNodes() { return default; }
	public bool IsTopLevelGraph() { return default; }
	public UObject GetDefaultFunctionLibrary() { return default; }
	public void SetDefaultFunctionLibrary(UObject InFunctionLibrary) {}
	public TArray<FRigVMGraphVariableDescription> GetLocalVariables(bool bIncludeInputArguments/*=false*/) { return default; }
	public TArray<FRigVMGraphVariableDescription> GetInputArguments() { return default; }
	public TArray<FRigVMGraphVariableDescription> GetOutputArguments() { return default; }
	public TArray<URigVMNode> Nodes;
	public TArray<URigVMLink> Links;
	public TArray<string> SelectedNodes;
	public TWeakObjectPtr<URigVMGraph> DefaultFunctionLibraryPtr;
	public UScriptStruct ExecuteContextStruct;
	public bool bEditable;
	public TArray<FRigVMGraphVariableDescription> LocalVariables;
}

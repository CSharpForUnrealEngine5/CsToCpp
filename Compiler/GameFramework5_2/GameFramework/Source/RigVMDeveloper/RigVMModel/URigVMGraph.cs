#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMGraph.h")]
///<summary>The Graph represents a Function definition</summary>
public partial class URigVMGraph : UObject {
// RigVMGraph
	public  TArray<URigVMNode> GetNodes() { return default; }
	public  TArray<URigVMLink> GetLinks() { return default; }
	public  TArray<URigVMGraph> GetContainedGraphs(bool bRecursive/*=false*/) { return default; }
	public  URigVMGraph GetParentGraph() { return default; }
	public  URigVMGraph GetRootGraph() { return default; }
	public  bool IsRootGraph() { return default; }
	public  URigVMFunctionEntryNode GetEntryNode() { return default; }
	public  URigVMFunctionReturnNode GetReturnNode() { return default; }
	public  TArray<FRigVMGraphVariableDescription> GetVariableDescriptions() { return default; }
	public  string GetNodePath() { return default; }
	public  string GetGraphName() { return default; }
	public  URigVMNode FindNodeByName(string InNodeName) { return default; }
	public  URigVMNode FindNode(string InNodePath) { return default; }
	public  URigVMPin FindPin(string InPinPath) { return default; }
	public  URigVMLink FindLink(string InLinkPinPathRepresentation) { return default; }
	public  bool IsNodeSelected(string InNodeName) { return default; }
	public  TArray<string> GetSelectNodes() { return default; }
	public  bool IsTopLevelGraph() { return default; }
	public  URigVMFunctionLibrary GetDefaultFunctionLibrary() { return default; }
	public  void SetDefaultFunctionLibrary(URigVMFunctionLibrary InFunctionLibrary) {}
	public  TArray<FRigVMGraphVariableDescription> GetLocalVariables(bool bIncludeInputArguments/*=false*/) { return default; }
	public  TArray<FRigVMGraphVariableDescription> GetInputArguments() { return default; }
	public  TArray<FRigVMGraphVariableDescription> GetOutputArguments() { return default; }
	public TArray<URigVMNode> Nodes;
	public TArray<URigVMLink> Links;
	public TArray<string> SelectedNodes;
	public TWeakObjectPtr<URigVMGraph> DefaultFunctionLibraryPtr;
	public UScriptStruct ExecuteContextStruct;
	public bool bEditable;
	public TArray<FRigVMGraphVariableDescription> LocalVariables;
}

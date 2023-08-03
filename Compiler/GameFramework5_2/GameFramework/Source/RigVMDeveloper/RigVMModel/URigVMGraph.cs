#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Graph represents a Function definition</summary>
[CppInclude("RigVMModel/RigVMGraph.h")]
public partial class URigVMGraph : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns all of the Nodes within this Graph.</summary>
	public  TArray<URigVMNode> GetNodes() { return default; }
	///<summary>Returns all of the Links within this Graph.</summary>
	public  TArray<URigVMLink> GetLinks() { return default; }
	///<summary>Returns all of the contained graphs</summary>
	public  TArray<URigVMGraph> GetContainedGraphs(bool bRecursive/*=false*/) { return default; }
	///<summary>Returns the parent graph of this graph</summary>
	public  URigVMGraph GetParentGraph() { return default; }
	///<summary>Returns the root / top level parent graph of this graph (or this if it is the root graph)</summary>
	public  URigVMGraph GetRootGraph() { return default; }
	///<summary>Returns true if this graph is a root / top level graph</summary>
	public  bool IsRootGraph() { return default; }
	///<summary>Returns the entry node of this graph</summary>
	public  URigVMFunctionEntryNode GetEntryNode() { return default; }
	///<summary>Returns the return node of this graph</summary>
	public  URigVMFunctionReturnNode GetReturnNode() { return default; }
	///<summary>Returns a list of unique Variable descriptions within this Graph.</summary>
	public  TArray<FRigVMGraphVariableDescription> GetVariableDescriptions() { return default; }
	///<summary>Returns the path of this graph as defined by its invoking nodes</summary>
	public  string GetNodePath() { return default; }
	///<summary>Returns the name of this graph (as defined by the node path)</summary>
	public  string GetGraphName() { return default; }
	///<summary>Returns a Node given its name (or nullptr).</summary>
	public  URigVMNode FindNodeByName(string InNodeName) { return default; }
	///<summary>Returns a Node given its path (or nullptr).</summary>
	public  URigVMNode FindNode(string InNodePath) { return default; }
	///<summary>Returns a Pin given its path, for example &quot;Node.Color.R&quot;.</summary>
	public  URigVMPin FindPin(string InPinPath) { return default; }
	///<summary>Returns a link given its string representation,</summary>
	public  URigVMLink FindLink(string InLinkPinPathRepresentation) { return default; }
	///<summary>Returns true if a Node with a given name is selected.</summary>
	public  bool IsNodeSelected(string InNodeName) { return default; }
	///<summary>Returns the names of all currently selected Nodes.</summary>
	public  TArray<string> GetSelectNodes() { return default; }
	///<summary>Returns true if this graph is the top level graph</summary>
	public  bool IsTopLevelGraph() { return default; }
	///<summary>Returns the locally available function library</summary>
	public  URigVMFunctionLibrary GetDefaultFunctionLibrary() { return default; }
	///<summary>SetDefaultFunctionLibrary</summary>
	public  void SetDefaultFunctionLibrary(URigVMFunctionLibrary InFunctionLibrary) {}
	///<summary>Returns the local variables of this function</summary>
	public  TArray<FRigVMGraphVariableDescription> GetLocalVariables(bool bIncludeInputArguments/*=false*/) { return default; }
	///<summary>Returns the input arguments of this graph</summary>
	public  TArray<FRigVMGraphVariableDescription> GetInputArguments() { return default; }
	///<summary>Returns the output arguments of this graph</summary>
	public  TArray<FRigVMGraphVariableDescription> GetOutputArguments() { return default; }
	///<summary>Nodes</summary>
	public TArray<URigVMNode> Nodes;
	///<summary>Links</summary>
	public TArray<URigVMLink> Links;
	///<summary>SelectedNodes</summary>
	public TArray<string> SelectedNodes;
	///<summary>DefaultFunctionLibraryPtr</summary>
	public TWeakObjectPtr<URigVMGraph> DefaultFunctionLibraryPtr;
	///<summary>ExecuteContextStruct</summary>
	public UScriptStruct ExecuteContextStruct;
	///<summary>bEditable</summary>
	public bool bEditable;
	///<summary>LocalVariables</summary>
	public TArray<FRigVMGraphVariableDescription> LocalVariables;
}

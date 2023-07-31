#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Node represents a single statement within a Graph.</summary>
[CppInclude("RigVMModel/RigVMNode.h")]
public partial class URigVMNode : UObject {
	///<summary>Returns the a . separated string containing all of the</summary>
	public  string GetNodePath(bool bRecursive/*=false*/) { return default; }
	///<summary>Returns the current index of the Node within the Graph.</summary>
	public  int GetNodeIndex() { return default; }
	///<summary>Returns all of the top-level Pins of this Node.</summary>
	public  TArray<URigVMPin> GetPins() { return default; }
	///<summary>Returns all of the Pins of this Node (including SubPins).</summary>
	public  TArray<URigVMPin> GetAllPinsRecursively() { return default; }
	///<summary>Returns a Pin given it&#39;s partial pin path below</summary>
	public  URigVMPin FindPin(string InPinPath) { return default; }
	///<summary>Returns all of the top-level orphaned Pins of this Node.</summary>
	public  TArray<URigVMPin> GetOrphanedPins() { return default; }
	///<summary>Returns true if the node has orphaned pins - which leads to a compiler error</summary>
	public  bool HasOrphanedPins() { return default; }
	///<summary>Returns the Graph of this Node</summary>
	public  URigVMGraph GetGraph() { return default; }
	///<summary>Returns the top level / root Graph of this Node</summary>
	public  URigVMGraph GetRootGraph() { return default; }
	///<summary>Returns the injection info of this Node (or nullptr)</summary>
	public  URigVMInjectionInfo GetInjectionInfo() { return default; }
	///<summary>Returns the title of this Node - used for UI.</summary>
	public  string GetNodeTitle() { return default; }
	///<summary>Returns the 2d position of this node - used for UI.</summary>
	public  FVector2D GetPosition() { return default; }
	///<summary>Returns the 2d size of this node - used for UI.</summary>
	public  FVector2D GetSize() { return default; }
	///<summary>Returns the color of this node - used for UI.</summary>
	public  FLinearColor GetNodeColor() { return default; }
	///<summary>Returns the tooltip of this node</summary>
	public  string GetToolTipText() { return default; }
	///<summary>Returns true if this Node is currently selected.</summary>
	public  bool IsSelected() { return default; }
	///<summary>Returns true if this is an injected node.</summary>
	public  bool IsInjected() { return default; }
	///<summary>Returns true if this should be visible in the UI</summary>
	public  bool IsVisibleInUI() { return default; }
	///<summary>Returns true if this Node has no side-effects</summary>
	public  bool IsPure() { return default; }
	///<summary>Returns true if the node is defined as non-varying</summary>
	public  bool IsDefinedAsConstant() { return default; }
	///<summary>Returns true if the node is defined as non-varying</summary>
	public  bool IsDefinedAsVarying() { return default; }
	///<summary>Returns true if this Node has side effects or</summary>
	public  bool IsMutable() { return default; }
	///<summary>Returns true if this Node is the beginning of a scope</summary>
	public  bool IsEvent() { return default; }
	///<summary>Returns the name of the event</summary>
	public  string GetEventName() { return default; }
	///<summary>Returns true if this node can only exist once in a graph</summary>
	public  bool CanOnlyExistOnce() { return default; }
	///<summary>Returns true if the node has any input pins</summary>
	public  bool HasInputPin(bool bIncludeIO/*=true*/) { return default; }
	///<summary>Returns true if the node has any io pins</summary>
	public  bool HasIOPin() { return default; }
	///<summary>Returns true if the node has any lazily evaluating pins</summary>
	public  bool HasLazyPin(bool bOnlyConsiderPinsWithLinks/*=false*/) { return default; }
	///<summary>Returns true if the node has any output pins</summary>
	public  bool HasOutputPin(bool bIncludeIO/*=true*/) { return default; }
	///<summary>Returns true if the node has any pins of the provided direction</summary>
	public  bool HasPinOfDirection(ERigVMPinDirection InDirection) { return default; }
	///<summary>Returns true if this Node is linked to another</summary>
	public  bool IsLinkedTo(URigVMNode InNode) { return default; }
	///<summary>Returns all links to any pin on this node</summary>
	public  TArray<URigVMLink> GetLinks() { return default; }
	///<summary>Returns a list of Nodes connected as sources to</summary>
	public  TArray<URigVMNode> GetLinkedSourceNodes() { return default; }
	///<summary>Returns a list of Nodes connected as targets to</summary>
	public  TArray<URigVMNode> GetLinkedTargetNodes() { return default; }
	///<summary>Returns the name of the node prior to the renaming</summary>
	public  string GetPreviousFName() { return default; }
	///<summary>return true if this node is a loop node</summary>
	public  bool IsLoopNode() { return default; }
	///<summary>return true if this node is a control flow node</summary>
	public  bool IsControlFlowNode() { return default; }
	///<summary>returns true if the node can be upgraded</summary>
	public  bool CanBeUpgraded() { return default; }
	///<summary>returns all supported workflows of the node</summary>
	public  TArray<FRigVMUserWorkflow> GetSupportedWorkflows(ERigVMUserWorkflowType InType,UObject InSubject) { return default; }
	///<summary>HasBreakpoint</summary>
	public  bool HasBreakpoint() { return default; }
	///<summary>SetHasBreakpoint</summary>
	public  void SetHasBreakpoint(bool bValue) {}
	///<summary>ExecutionIsHaltedAtThisNode</summary>
	public  bool ExecutionIsHaltedAtThisNode() { return default; }
	///<summary>SetExecutionIsHaltedAtThisNode</summary>
	public  void SetExecutionIsHaltedAtThisNode(bool bValue) {}
	///<summary>IsAggregate</summary>
	public  bool IsAggregate() { return default; }
	///<summary>GetFirstAggregatePin</summary>
	public  URigVMPin GetFirstAggregatePin() { return default; }
	///<summary>GetSecondAggregatePin</summary>
	public  URigVMPin GetSecondAggregatePin() { return default; }
	///<summary>GetOppositeAggregatePin</summary>
	public  URigVMPin GetOppositeAggregatePin() { return default; }
	///<summary>IsInputAggregate</summary>
	public  bool IsInputAggregate() { return default; }
	///<summary>GetAggregateInputs</summary>
	public  TArray<URigVMPin> GetAggregateInputs() { return default; }
	///<summary>GetAggregateOutputs</summary>
	public  TArray<URigVMPin> GetAggregateOutputs() { return default; }
	///<summary>GetNextAggregateName</summary>
	public  string GetNextAggregateName(string InLastAggregatePinName) { return default; }
	///<summary>FindFunctionForNode</summary>
	public  URigVMLibraryNode FindFunctionForNode() { return default; }
	///<summary>NodeTitle</summary>
	public string NodeTitle;
	///<summary>Position</summary>
	public FVector2D Position;
	///<summary>Size</summary>
	public FVector2D Size;
	///<summary>NodeColor</summary>
	public FLinearColor NodeColor;
	///<summary>PreviousName</summary>
	public string PreviousName;
	///<summary>bHasBreakpoint</summary>
	public bool bHasBreakpoint;
	///<summary>bHaltedAtThisNode</summary>
	public bool bHaltedAtThisNode;
	///<summary>Pins</summary>
	public TArray<URigVMPin> Pins;
	///<summary>OrphanedPins</summary>
	public TArray<URigVMPin> OrphanedPins;
}

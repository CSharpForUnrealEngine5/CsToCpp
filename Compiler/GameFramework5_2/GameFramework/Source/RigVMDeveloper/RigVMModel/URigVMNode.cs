#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMNode.h")]
///<summary>The Node represents a single statement within a Graph.</summary>
public partial class URigVMNode : UObject {
// RigVMNode
	public string GetNodePath(bool bRecursive/*=false*/) { return default; }
	public int GetNodeIndex() { return default; }
	public TArray<UObject> GetPins() { return default; }
	public TArray<UObject> GetAllPinsRecursively() { return default; }
	public UObject FindPin(string InPinPath) { return default; }
	public TArray<UObject> GetOrphanedPins() { return default; }
	public bool HasOrphanedPins() { return default; }
	public UObject GetGraph() { return default; }
	public UObject GetRootGraph() { return default; }
	public UObject GetInjectionInfo() { return default; }
	public string GetNodeTitle() { return default; }
	public FVector2D GetPosition() { return default; }
	public FVector2D GetSize() { return default; }
	public FLinearColor GetNodeColor() { return default; }
	public string GetToolTipText() { return default; }
	public bool IsSelected() { return default; }
	public bool IsInjected() { return default; }
	public bool IsVisibleInUI() { return default; }
	public bool IsPure() { return default; }
	public bool IsDefinedAsConstant() { return default; }
	public bool IsDefinedAsVarying() { return default; }
	public bool IsMutable() { return default; }
	public bool IsEvent() { return default; }
	public string GetEventName() { return default; }
	public bool CanOnlyExistOnce() { return default; }
	public bool HasInputPin(bool bIncludeIO/*=true*/) { return default; }
	public bool HasIOPin() { return default; }
	public bool HasLazyPin(bool bOnlyConsiderPinsWithLinks/*=false*/) { return default; }
	public bool HasOutputPin(bool bIncludeIO/*=true*/) { return default; }
	public bool HasPinOfDirection(ERigVMPinDirection InDirection) { return default; }
	public bool IsLinkedTo(UObject InNode) { return default; }
	public TArray<UObject> GetLinks() { return default; }
	public TArray<UObject> GetLinkedSourceNodes() { return default; }
	public TArray<UObject> GetLinkedTargetNodes() { return default; }
	public string GetPreviousFName() { return default; }
	public bool IsLoopNode() { return default; }
	public bool IsControlFlowNode() { return default; }
	public bool CanBeUpgraded() { return default; }
	public TArray<FRigVMUserWorkflow> GetSupportedWorkflows(ERigVMUserWorkflowType InType,UObject InSubject) { return default; }
	public bool HasBreakpoint() { return default; }
	public void SetHasBreakpoint(bool bValue) {}
	public bool ExecutionIsHaltedAtThisNode() { return default; }
	public void SetExecutionIsHaltedAtThisNode(bool bValue) {}
	public bool IsAggregate() { return default; }
	public UObject GetFirstAggregatePin() { return default; }
	public UObject GetSecondAggregatePin() { return default; }
	public UObject GetOppositeAggregatePin() { return default; }
	public bool IsInputAggregate() { return default; }
	public TArray<UObject> GetAggregateInputs() { return default; }
	public TArray<UObject> GetAggregateOutputs() { return default; }
	public string GetNextAggregateName(string InLastAggregatePinName) { return default; }
	public UObject FindFunctionForNode() { return default; }
	public string NodeTitle;
	public FVector2D Position;
	public FVector2D Size;
	public FLinearColor NodeColor;
	public string PreviousName;
	public bool bHasBreakpoint;
	public bool bHaltedAtThisNode;
	public TArray<URigVMPin> Pins;
	public TArray<URigVMPin> OrphanedPins;
}

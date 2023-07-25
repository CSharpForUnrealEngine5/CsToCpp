#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/ControlRigGraphNode.h")]
///<summary>Base class for animation ControlRig-related nodes</summary>
public partial class UControlRigGraphNode : UEdGraphNode {
// ControlRigGraphNode
	public string ModelNodePath;
	public TWeakObjectPtr<URigVMNode> CachedModelNode;
	public TMap<string,TWeakObjectPtr<URigVMPin>> PinPathToModelPin;
	public string PropertyName_DEPRECATED;
	public string StructPath_DEPRECATED;
	public FEdGraphPinType PinType_DEPRECATED;
	public int ParameterType_DEPRECATED;
	public TArray<string> ExpandedPins_DEPRECATED;
}

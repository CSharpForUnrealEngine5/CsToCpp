#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for animation ControlRig-related nodes</summary>
[CppInclude("Graph/ControlRigGraphNode.h")]
public partial class UControlRigGraphNode : UEdGraphNode {
	///<summary>ModelNodePath</summary>
	public string ModelNodePath;
	///<summary>CachedModelNode</summary>
	public TWeakObjectPtr<URigVMNode> CachedModelNode;
	///<summary>PinPathToModelPin</summary>
	public TMap<string,TWeakObjectPtr<URigVMPin>> PinPathToModelPin;
	///<summary>The property we represent. For template nodes this represents the struct/property type name.</summary>
	public string PropertyName_DEPRECATED;
	///<summary>StructPath_DEPRECATED</summary>
	public string StructPath_DEPRECATED;
	///<summary>Pin Type for property</summary>
	public FEdGraphPinType PinType_DEPRECATED;
	///<summary>The type of parameter</summary>
	public int ParameterType_DEPRECATED;
	///<summary>Expanded pins</summary>
	public TArray<string> ExpandedPins_DEPRECATED;
}

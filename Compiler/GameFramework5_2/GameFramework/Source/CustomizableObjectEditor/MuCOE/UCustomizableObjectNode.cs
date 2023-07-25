#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNode.h")]
///<summary>Base class of all Customizable Object nodes.</summary>
public partial class UCustomizableObjectNode : UEdGraphNode {
// CustomizableObjectNode
	public FPostEditChangePropertyDelegate PostEditChangePropertyDelegate;
	public TMap<FGuid,UCustomizableObjectNodePinData> PinsDataId;
	public TMap<FEdGraphPinReference,UCustomizableObjectNodePinData> PinsData_DEPRECATED;
}

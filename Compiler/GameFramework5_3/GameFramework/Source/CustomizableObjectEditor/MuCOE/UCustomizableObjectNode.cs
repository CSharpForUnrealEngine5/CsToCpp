namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of all Customizable Object nodes.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNode.h")]
public partial class UCustomizableObjectNode : UEdGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>PostEditChangePropertyDelegate</summary>
	public FPostEditChangePropertyDelegate PostEditChangePropertyDelegate;
	///<summary>Data attached to a given pin. Not all pins contain data.</summary>
	public TMap<FGuid,UCustomizableObjectNodePinData> PinsDataId;
	///<summary>Deprectated properties</summary>
	public TMap<FEdGraphPinReference,UCustomizableObjectNodePinData> PinsData_DEPRECATED;
}

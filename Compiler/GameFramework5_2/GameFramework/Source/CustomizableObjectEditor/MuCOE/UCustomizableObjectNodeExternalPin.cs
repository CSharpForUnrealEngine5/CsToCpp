#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeExternalPin.h")]
public partial class UCustomizableObjectNodeExternalPin : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>This is actually PinCategory</summary>
	public string PinType;
	///<summary>External Customizable Object which the linked Node Expose Pin belong to.</summary>
	public UCustomizableObject ExternalObject;
	///<summary>Linked Node Expose Pin node guid.</summary>
	public FGuid ExternalObjectNodeId;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeSwitchBase.h")]
public partial class UCustomizableObjectNodeSwitchBase : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>OutputPinReference</summary>
	public FEdGraphPinReference OutputPinReference;
	///<summary>NodeEnumParameter property changed callback function. Reconstructs the node.</summary>
	public  void EnumParameterPostEditChangeProperty(FPostEditChangePropertyDelegateParameters Parameters) {}
	///<summary>ReloadingElementsNames</summary>
	public TArray<string> ReloadingElementsNames;
	///<summary>SwitchParameterPinReference</summary>
	public FEdGraphPinReference SwitchParameterPinReference;
}

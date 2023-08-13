namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Additional data for the Parent Texture Parameter to edit pin.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeEditMaterial.h")]
public partial class UCustomizableObjectNodeEditMaterialPinEditImageData : UCustomizableObjectNodePinData {
	public static UClass StaticClass() {return default;}
	///<summary>ImageId</summary>
	public FGuid ImageId;
	///<summary>PinMask</summary>
	public FEdGraphPinReference PinMask;
}

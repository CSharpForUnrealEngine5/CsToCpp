namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Additional data for Image pins.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTable.h")]
public partial class UCustomizableObjectNodeTableImagePinData : UCustomizableObjectNodeTableObjectPinData {
	public static UClass StaticClass() {return default;}
	///<summary>Pin Type</summary>
	public ETableTextureType ImageMode;
	///<summary>bIsDefault</summary>
	public bool bIsDefault;
	///<summary>bIsArrayTexture</summary>
	public bool bIsArrayTexture;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMaterial.h")]
///<summary>Additional data for a Material Texture Parameter pin.</summary>
public partial class UCustomizableObjectNodeMaterialPinDataImage : UCustomizableObjectNodeMaterialPinDataParameter {
// CustomizableObjectNodeMaterialPinDataImage
	public EPinMode PinMode;
	public int UVLayout;
	public UTexture2D ReferenceTexture;
	public UCustomizableObjectNodeMaterial NodeMaterial;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Additional data for a Material Texture Parameter pin.</summary>
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeMaterial.h")]
public partial class UCustomizableObjectNodeMaterialPinDataImage : UCustomizableObjectNodeMaterialPinDataParameter {
	public static UClass StaticClass() {return default;}
	///<summary>Image pin mode. If is not default, overrides the defined node behaviour.</summary>
	public EPinMode PinMode;
	///<summary>Index of the UV channel that will be used with this image.It is necessary to apply the proper layout transformations to it.</summary>
	public int UVLayout;
	///<summary>Reference Texture used to decide the texture properties of the mutable-generated textures</summary>
	public UTexture2D ReferenceTexture;
	///<summary>NodeMaterial</summary>
	public UCustomizableObjectNodeMaterial NodeMaterial;
}

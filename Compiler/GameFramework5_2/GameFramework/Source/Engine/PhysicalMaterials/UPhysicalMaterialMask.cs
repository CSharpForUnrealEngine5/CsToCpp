#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicalMaterials/PhysicalMaterialMask.h")]
///<summary>Physical material masks are used to map multiple physical materials to a single rendering material</summary>
public partial class UPhysicalMaterialMask : UObject {
// PhysicalMaterialMask
	public UAssetImportData AssetImportData;
	public UTexture MaskTexture;
	public int UVChannelIndex;
	public TextureAddress AddressX;
	public TextureAddress AddressY;
}

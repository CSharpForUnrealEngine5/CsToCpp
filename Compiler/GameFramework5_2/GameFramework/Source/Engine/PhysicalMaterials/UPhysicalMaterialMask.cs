#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Physical material masks are used to map multiple physical materials to a single rendering material</summary>
[CppInclude("PhysicalMaterials/PhysicalMaterialMask.h")]
public partial class UPhysicalMaterialMask : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AssetImportData</summary>
	public UAssetImportData AssetImportData;
	///<summary>Mask input texture, square aspect ratio recommended. Recognized mask colors include: white, black, red, green, yellow, cyan, turquoise, and magenta.</summary>
	public UTexture MaskTexture;
	///<summary>StaticMesh UV channel index to use when performing lookups with this mask.</summary>
	public int UVChannelIndex;
	///<summary>The addressing mode to use for the X axis.</summary>
	public TextureAddress AddressX;
	///<summary>The addressing mode to use for the Y axis.</summary>
	public TextureAddress AddressY;
}

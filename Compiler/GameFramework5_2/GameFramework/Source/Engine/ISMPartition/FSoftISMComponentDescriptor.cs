#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMPartition/ISMComponentDescriptor.h")]
public partial struct FSoftISMComponentDescriptor {
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	public TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterials;
	public TArray<TSoftObjectPtr<URuntimeVirtualTexture>> RuntimeVirtualTextures;
}

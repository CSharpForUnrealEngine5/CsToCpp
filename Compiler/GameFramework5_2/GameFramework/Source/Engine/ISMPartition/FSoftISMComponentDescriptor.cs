#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMPartition/ISMComponentDescriptor.h")]
public partial struct FSoftISMComponentDescriptor {
// SoftISMComponentDescriptor
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	public TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterials;
	public TArray<TSoftObjectPtr<URuntimeVirtualTexture>> RuntimeVirtualTextures;
}

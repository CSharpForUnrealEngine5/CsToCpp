namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMPartition/ISMComponentDescriptor.h")]
public partial struct FSoftISMComponentDescriptor {
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	public TArray<TSoftObjectPtr<UMaterialInterface>> OverrideMaterials;
	public TSoftObjectPtr<UMaterialInterface> OverlayMaterial;
	public TArray<TSoftObjectPtr<URuntimeVirtualTexture>> RuntimeVirtualTextures;
}

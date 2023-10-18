namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMPartition/ISMComponentDescriptor.h")]
public partial struct FISMComponentDescriptor {
	public UStaticMesh StaticMesh;
	public TArray<UMaterialInterface> OverrideMaterials;
	public UMaterialInterface OverlayMaterial;
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
}

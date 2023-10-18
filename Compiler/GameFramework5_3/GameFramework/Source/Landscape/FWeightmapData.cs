namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeComponent.h")]
public partial struct FWeightmapData {
	public TArray<UTexture2D> Textures;
	public TArray<FWeightmapLayerAllocationInfo> LayerAllocations;
	public TArray<ULandscapeWeightmapUsage> TextureUsages;
}

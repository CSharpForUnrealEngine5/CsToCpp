#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeComponent.h")]
public partial struct FWeightmapData {
// WeightmapData
	public TArray<UTexture2D> Textures;
	public TArray<FWeightmapLayerAllocationInfo> LayerAllocations;
	public TArray<ULandscapeWeightmapUsage> TextureUsages;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGTextureSampler.h")]
public partial class UPCGTextureSamplerSettings : UPCGSettings {
// PCGTextureSamplerSettings
	public FTransform Transform;
	public bool bUseAbsoluteTransform;
	public TSoftObjectPtr<UTexture2D> Texture;
	public EPCGTextureDensityFunction DensityFunction;
	public EPCGTextureColorChannel ColorChannel;
	public float TexelSize;
	public bool bUseAdvancedTiling;
	public FVector2D Tiling;
	public FVector2D CenterOffset;
	public float Rotation;
	public bool bUseTileBounds;
	public FVector2D TileBoundsMin;
	public FVector2D TileBoundsMax;
}

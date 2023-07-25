#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGTextureData.h")]
public partial class UPCGBaseTextureData : UPCGSurfaceData {
// PCGBaseTextureData
	public EPCGTextureDensityFunction DensityFunction;
	public EPCGTextureColorChannel ColorChannel;
	public float TexelSize;
	public bool bUseAdvancedTiling;
	public FVector2D Tiling;
	public FVector2D CenterOffset;
	public float Rotation;
	public bool bUseTileBounds;
	public FBox2D TileBounds;
	public TArray<FLinearColor> ColorData;
	public FBox Bounds;
	public int Height;
	public int Width;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGTextureSampler.h")]
public partial class UPCGTextureSamplerSettings : UPCGSettings {
	///<summary>Surface transform</summary>
	public FTransform Transform;
	///<summary>bUseAbsoluteTransform</summary>
	public bool bUseAbsoluteTransform;
	///<summary>Texture specific parameters</summary>
	public TSoftObjectPtr<UTexture2D> Texture;
	///<summary>Common members in BaseTextureData</summary>
	public EPCGTextureDensityFunction DensityFunction;
	///<summary>ColorChannel</summary>
	public EPCGTextureColorChannel ColorChannel;
	///<summary>The size of one texel in cm, used when calling ToPointData.</summary>
	public float TexelSize;
	///<summary>Whether to tile the source or to stretch it to fit target area.</summary>
	public bool bUseAdvancedTiling;
	///<summary>Tiling</summary>
	public FVector2D Tiling;
	///<summary>CenterOffset</summary>
	public FVector2D CenterOffset;
	///<summary>Rotation to apply when sampling texture.</summary>
	public float Rotation;
	///<summary>bUseTileBounds</summary>
	public bool bUseTileBounds;
	///<summary>TileBoundsMin</summary>
	public FVector2D TileBoundsMin;
	///<summary>TileBoundsMax</summary>
	public FVector2D TileBoundsMax;
}

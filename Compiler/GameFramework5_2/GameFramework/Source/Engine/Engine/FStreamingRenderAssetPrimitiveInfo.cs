#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureStreamingTypes.h")]
///<summary>Information about a streaming texture/mesh that a primitive uses for rendering.</summary>
public partial struct FStreamingRenderAssetPrimitiveInfo {
// StreamingRenderAssetPrimitiveInfo
	public UStreamableRenderAsset RenderAsset;
	public FBoxSphereBounds Bounds;
	public float TexelFactor;
	public uint PackedRelativeBox;
	public bool bAllowInvalidTexelFactorWhenUnregistered;
	public bool bAffectedByComponentScale;
}

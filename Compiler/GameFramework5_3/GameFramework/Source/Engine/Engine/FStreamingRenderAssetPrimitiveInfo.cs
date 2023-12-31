namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a streaming texture/mesh that a primitive uses for rendering.</summary>
[CppInclude("Engine/TextureStreamingTypes.h")]
public partial struct FStreamingRenderAssetPrimitiveInfo {
	public UStreamableRenderAsset RenderAsset;
	public FBoxSphereBounds Bounds;
	public float TexelFactor;
	public uint PackedRelativeBox;
	public bool bAllowInvalidTexelFactorWhenUnregistered;
	public bool bAffectedByComponentScale;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TextureStreamingTypes.h")]
///<summary>This struct holds the result of TextureStreaming Build for each component texture, as referred by its used materials.</summary>
public partial struct FStreamingTextureBuildInfo {
// StreamingTextureBuildInfo
	public uint PackedRelativeBox;
	public int TextureLevelIndex;
	public float TexelFactor;
}

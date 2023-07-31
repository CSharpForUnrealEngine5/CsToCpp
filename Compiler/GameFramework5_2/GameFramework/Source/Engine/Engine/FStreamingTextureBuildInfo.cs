#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct holds the result of TextureStreaming Build for each component texture, as referred by its used materials.</summary>
[CppInclude("Engine/TextureStreamingTypes.h")]
public partial struct FStreamingTextureBuildInfo {
	public uint PackedRelativeBox;
	public int TextureLevelIndex;
	public float TexelFactor;
}

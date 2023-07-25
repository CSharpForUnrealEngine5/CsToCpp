#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInterface.h")]
///<summary>This struct holds data about how a texture is sampled within a material.</summary>
public partial struct FMaterialTextureInfo {
// MaterialTextureInfo
	public float SamplingScale;
	public int UVChannelIndex;
	public string TextureName;
	public FSoftObjectPath TextureReference;
	public int TextureIndex;
}

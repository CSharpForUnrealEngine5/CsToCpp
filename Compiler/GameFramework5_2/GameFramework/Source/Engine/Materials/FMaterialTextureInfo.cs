namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This struct holds data about how a texture is sampled within a material.</summary>
[CppInclude("Materials/MaterialInterface.h")]
public partial struct FMaterialTextureInfo {
	public float SamplingScale;
	public int UVChannelIndex;
	public FName TextureName;
	public FSoftObjectPath TextureReference;
	public int TextureIndex;
}

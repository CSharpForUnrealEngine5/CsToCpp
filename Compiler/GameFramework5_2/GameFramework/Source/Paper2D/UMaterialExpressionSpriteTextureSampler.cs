#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialExpressionSpriteTextureSampler.h")]
///<summary>This is a texture sampler 2D with a special automatically defined parameter name. The texture specified here will be replaced by the SourceTexture or an AdditionalSourceTextures entry of a Paper2D sprite if this material is used on a sprite.</summary>
public partial class UMaterialExpressionSpriteTextureSampler : UMaterialExpressionTextureSampleParameter2D {
// MaterialExpressionSpriteTextureSampler
	public bool bSampleAdditionalTextures;
	public int AdditionalSlotIndex;
	public string SlotDisplayName;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a texture sampler 2D with a special automatically defined parameter name. The texture specified here will be replaced by the SourceTexture or an AdditionalSourceTextures entry of a Paper2D sprite if this material is used on a sprite.</summary>
[CppInclude("MaterialExpressionSpriteTextureSampler.h")]
public partial class UMaterialExpressionSpriteTextureSampler : UMaterialExpressionTextureSampleParameter2D {
	///<summary>Is this a sampler for the default SourceTexture or the AdditionalSourceTextures list?</summary>
	public bool bSampleAdditionalTextures;
	///<summary>This is the slot index into the AdditionalSourceTextures array</summary>
	public int AdditionalSlotIndex;
	///<summary>Friendly label for the texture slot, displayed in the Sprite Editor if not empty</summary>
	public string SlotDisplayName;
}

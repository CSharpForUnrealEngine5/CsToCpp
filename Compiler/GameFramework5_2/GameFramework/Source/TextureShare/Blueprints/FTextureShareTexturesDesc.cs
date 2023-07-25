#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/TextureShareBlueprintContainersBase.h")]
///<summary>Custom textures for sharing</summary>
public partial struct FTextureShareTexturesDesc {
// TextureShareTexturesDesc
	public TArray<FTextureShareSendTextureDesc> SendTextures;
	public TArray<FTextureShareReceiveTextureDesc> ReceiveTextures;
}

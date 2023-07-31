#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom textures for sharing</summary>
[CppInclude("Blueprints/TextureShareBlueprintContainersBase.h")]
public partial struct FTextureShareTexturesDesc {
	public TArray<FTextureShareSendTextureDesc> SendTextures;
	public TArray<FTextureShareReceiveTextureDesc> ReceiveTextures;
}

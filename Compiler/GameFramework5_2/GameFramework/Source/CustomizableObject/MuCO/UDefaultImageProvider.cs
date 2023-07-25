#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/DefaultImageProvider.h")]
///<summary>Simple image provider that translates UTexture2D to Mutable IDs.</summary>
public partial class UDefaultImageProvider : UCustomizableSystemImageProvider {
// DefaultImageProvider
	public TArray<UTexture2D> Textures;
	public TArray<bool> KeepTextures;
}

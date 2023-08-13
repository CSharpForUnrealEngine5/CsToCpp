namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple image provider that translates UTexture2D to Mutable IDs.</summary>
[CppInclude("MuCO/DefaultImageProvider.h")]
public partial class UDefaultImageProvider : UCustomizableSystemImageProvider {
	public static UClass StaticClass() {return default;}
	///<summary>Textures</summary>
	public TArray<UTexture2D> Textures;
	///<summary>KeepTextures</summary>
	public TArray<bool> KeepTextures;
}

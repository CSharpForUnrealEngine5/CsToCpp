namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTextureProject.h")]
public partial class UCustomizableObjectNodeTextureProject : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>Layout to use for the generated images.</summary>
	public byte Layout;
	///<summary>bEnableAngleFadeOutForRGB</summary>
	public bool bEnableAngleFadeOutForRGB;
	///<summary>bEnableAngleFadeOutForAlpha</summary>
	public bool bEnableAngleFadeOutForAlpha;
	///<summary>Set the width of the Texture. If the reference texture is not null, it overrides the Size X property</summary>
	public uint TextureSizeX;
	///<summary>Set the height of the Texture. If the reference texture is not null, it overrides the Size Y property</summary>
	public uint TextureSizeY;
	///<summary>Textures</summary>
	public uint Textures;
	///<summary>Reference Texture used to decide the texture properties of the mutable-generated textures</summary>
	public UTexture2D ReferenceTexture;
	///<summary>TexturePinsReferences</summary>
	public TArray<FEdGraphPinReference> TexturePinsReferences;
	///<summary>OutputPinsReferences</summary>
	public TArray<FEdGraphPinReference> OutputPinsReferences;
}

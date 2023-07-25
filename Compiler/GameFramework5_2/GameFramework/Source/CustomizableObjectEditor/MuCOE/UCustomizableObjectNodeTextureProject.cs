#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTextureProject.h")]
public partial class UCustomizableObjectNodeTextureProject : UCustomizableObjectNode {
// CustomizableObjectNodeTextureProject
	public byte Layout;
	public bool bEnableAngleFadeOutForRGB;
	public bool bEnableAngleFadeOutForAlpha;
	public uint TextureSizeX;
	public uint TextureSizeY;
	public uint Textures;
	public UTexture2D ReferenceTexture;
	public TArray<FEdGraphPinReference> TexturePinsReferences;
	public TArray<FEdGraphPinReference> OutputPinsReferences;
}

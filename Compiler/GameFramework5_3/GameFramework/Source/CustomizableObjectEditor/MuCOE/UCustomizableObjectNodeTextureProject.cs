namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTextureProject.h")]
public partial class UCustomizableObjectNodeTextureProject : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>Layout to use for the generated images.</summary>
	public byte Layout;
	///<summary>When this is enable, additional operations will happen to correct projections that go over a texture UV seam to prevent interpolation artifacts.</summary>
	public bool bEnableTextureSeamCorrection;
	///<summary>bEnableAngleFadeOutForRGB</summary>
	public bool bEnableAngleFadeOutForRGB;
	///<summary>bEnableAngleFadeOutForAlpha</summary>
	public bool bEnableAngleFadeOutForAlpha;
	///<summary>SamplingMethod</summary>
	public ETextureProjectSamplingMethod SamplingMethod;
	///<summary>MinFilterMethod</summary>
	public ETextureProjectMinFilterMethod MinFilterMethod;
	///<summary>Set the width of the Texture. If greater than zero, it overrides the Reference Texture width.</summary>
	public uint TextureSizeX;
	///<summary>Set the height of the Texture. If greater than zero, it overrides the Reference Texture height.</summary>
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

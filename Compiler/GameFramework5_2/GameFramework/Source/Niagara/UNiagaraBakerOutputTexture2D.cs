#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerOutputTexture2D.h")]
public partial class UNiagaraBakerOutputTexture2D : UNiagaraBakerOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Source visualization we should capture, i.e. Scene Color, World Normal, etc</summary>
	public FNiagaraBakerTextureSource SourceBinding;
	///<summary>bGenerateAtlas</summary>
	public bool bGenerateAtlas;
	///<summary>bGenerateFrames</summary>
	public bool bGenerateFrames;
	///<summary>bExportFrames</summary>
	public bool bExportFrames;
	///<summary>bSetTextureAddressX</summary>
	public bool bSetTextureAddressX;
	///<summary>bSetTextureAddressY</summary>
	public bool bSetTextureAddressY;
	///<summary>Size of each frame we generate.</summary>
	public FIntPoint FrameSize;
	///<summary>Size of the atlas texture when generating an atlas.</summary>
	public FIntPoint AtlasTextureSize;
	///<summary>After baking sets the texture address mode to use on the X axis.</summary>
	public TextureAddress TextureAddressX;
	///<summary>After baking sets the texture address mode to use on the Y axis.</summary>
	public TextureAddress TextureAddressY;
	///<summary>When enabled a texture atlas is created</summary>
	public string AtlasAssetPathFormat;
	///<summary>When enabled each frame will create an asset.</summary>
	public string FramesAssetPathFormat;
	///<summary>When enabled each frame will be exported to the output path using the format extension.</summary>
	public string FramesExportPathFormat;
}

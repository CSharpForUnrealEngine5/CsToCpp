#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerOutputTexture2D.h")]
public partial class UNiagaraBakerOutputTexture2D : UNiagaraBakerOutput {
// NiagaraBakerOutputTexture2D
	public FNiagaraBakerTextureSource SourceBinding;
	public bool bGenerateAtlas;
	public bool bGenerateFrames;
	public bool bExportFrames;
	public bool bSetTextureAddressX;
	public bool bSetTextureAddressY;
	public FIntPoint FrameSize;
	public FIntPoint AtlasTextureSize;
	public byte TextureAddressX;
	public byte TextureAddressY;
	public string AtlasAssetPathFormat;
	public string FramesAssetPathFormat;
	public string FramesExportPathFormat;
}

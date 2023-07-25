#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerOutputVolumeTexture.h")]
public partial class UNiagaraBakerOutputVolumeTexture : UNiagaraBakerOutput {
// NiagaraBakerOutputVolumeTexture
	public FNiagaraBakerTextureSource SourceBinding;
	public bool bGenerateAtlas;
	public bool bGenerateFrames;
	public bool bExportFrames;
	public string AtlasAssetPathFormat;
	public string FramesAssetPathFormat;
	public string FramesExportPathFormat;
}

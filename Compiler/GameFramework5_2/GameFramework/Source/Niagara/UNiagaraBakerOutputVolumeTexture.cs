#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerOutputVolumeTexture.h")]
public partial class UNiagaraBakerOutputVolumeTexture : UNiagaraBakerOutput {
	///<summary>SourceBinding</summary>
	public FNiagaraBakerTextureSource SourceBinding;
	///<summary>bGenerateAtlas</summary>
	public bool bGenerateAtlas;
	///<summary>bGenerateFrames</summary>
	public bool bGenerateFrames;
	///<summary>bExportFrames</summary>
	public bool bExportFrames;
	///<summary>When enabled a volume atlas is created, the atlas is along X &amp; Y not Z based on baker settings.</summary>
	public string AtlasAssetPathFormat;
	///<summary>When enabled each frame will create an asset.</summary>
	public string FramesAssetPathFormat;
	///<summary>When enabled each frame will be exported to the output path using the format extension.</summary>
	public string FramesExportPathFormat;
}

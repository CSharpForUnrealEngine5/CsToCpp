#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerSettings.h")]
public partial struct FNiagaraBakerTextureSettings {
// NiagaraBakerTextureSettings
	public string OutputName;
	public FNiagaraBakerTextureSource SourceBinding;
	public bool bUseFrameSize;
	public FIntPoint FrameSize;
	public FIntPoint TextureSize;
	public UTexture2D GeneratedTexture;
}

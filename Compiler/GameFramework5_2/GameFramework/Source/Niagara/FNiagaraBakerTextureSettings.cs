namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraBakerSettings.h")]
public partial struct FNiagaraBakerTextureSettings {
	public FName OutputName;
	public FNiagaraBakerTextureSource SourceBinding;
	public bool bUseFrameSize;
	public FIntPoint FrameSize;
	public FIntPoint TextureSize;
	public UTexture2D GeneratedTexture;
}

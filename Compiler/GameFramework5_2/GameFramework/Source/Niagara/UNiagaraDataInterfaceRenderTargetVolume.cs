#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRenderTargetVolume.h")]
public partial class UNiagaraDataInterfaceRenderTargetVolume : UNiagaraDataInterfaceRWBase {
// NiagaraDataInterfaceRenderTargetVolume
	public FIntVector Size;
	public ETextureRenderTargetFormat OverrideRenderTargetFormat;
	public TextureFilter OverrideRenderTargetFilter;
	public bool bInheritUserParameterSettings;
	public bool bOverrideFormat;
	public bool bPreviewRenderTarget;
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public TMap<ulong,UTextureRenderTargetVolume> ManagedRenderTargets;
}

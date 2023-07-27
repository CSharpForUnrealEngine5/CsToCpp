#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRenderTarget2D.h")]
public partial class UNiagaraDataInterfaceRenderTarget2D : UNiagaraDataInterfaceRWBase {
// NiagaraDataInterfaceRenderTarget2D
	public FIntPoint Size;
	public ENiagaraMipMapGeneration MipMapGeneration;
	public ENiagaraMipMapGenerationType MipMapGenerationType;
	public ETextureRenderTargetFormat OverrideRenderTargetFormat;
	public TextureFilter OverrideRenderTargetFilter;
	public bool bInheritUserParameterSettings;
	public bool bOverrideFormat;
	public bool bPreviewRenderTarget;
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public TMap<ulong,UTextureRenderTarget2D> ManagedRenderTargets;
}

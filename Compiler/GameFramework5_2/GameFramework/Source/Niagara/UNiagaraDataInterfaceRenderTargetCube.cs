#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRenderTargetCube.h")]
public partial class UNiagaraDataInterfaceRenderTargetCube : UNiagaraDataInterfaceRWBase {
// NiagaraDataInterfaceRenderTargetCube
	public int Size;
	public byte OverrideRenderTargetFormat;
	public byte OverrideRenderTargetFilter;
	public bool bInheritUserParameterSettings;
	public bool bOverrideFormat;
	public bool bPreviewRenderTarget;
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public TMap<ulong,UTextureRenderTargetCube> ManagedRenderTargets;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRenderTarget2DArray.h")]
public partial class UNiagaraDataInterfaceRenderTarget2DArray : UNiagaraDataInterfaceRWBase {
// NiagaraDataInterfaceRenderTarget2DArray
	public FIntVector Size;
	public byte OverrideRenderTargetFormat;
	public byte OverrideRenderTargetFilter;
	public bool bInheritUserParameterSettings;
	public bool bOverrideFormat;
	public bool bPreviewRenderTarget;
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public TMap<ulong,UTextureRenderTarget2DArray> ManagedRenderTargets;
}

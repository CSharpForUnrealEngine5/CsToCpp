#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceIntRenderTarget2D.h")]
public partial class UNiagaraDataInterfaceIntRenderTarget2D : UNiagaraDataInterfaceRWBase {
// NiagaraDataInterfaceIntRenderTarget2D
	public FIntPoint Size;
	public bool bPreviewRenderTarget;
	public FVector2D PreviewDisplayRange;
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public TMap<ulong,UTextureRenderTarget2D> ManagedRenderTargets;
}

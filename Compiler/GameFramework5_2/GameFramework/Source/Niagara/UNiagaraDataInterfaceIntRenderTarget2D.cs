#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceIntRenderTarget2D.h")]
public partial class UNiagaraDataInterfaceIntRenderTarget2D : UNiagaraDataInterfaceRWBase {
	///<summary>Size</summary>
	public FIntPoint Size;
	///<summary>bPreviewRenderTarget</summary>
	public bool bPreviewRenderTarget;
	///<summary>The range to normaliez the preview display to.</summary>
	public FVector2D PreviewDisplayRange;
	///<summary>When valid the user parameter is used as the render target rather than creating one internal, note that the input render target will be adjusted by the Niagara simulation</summary>
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	///<summary>ManagedRenderTargets</summary>
	public TMap<ulong,UTextureRenderTarget2D> ManagedRenderTargets;
}

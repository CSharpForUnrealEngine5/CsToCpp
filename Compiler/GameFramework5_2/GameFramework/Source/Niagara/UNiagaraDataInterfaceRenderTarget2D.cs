#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceRenderTarget2D.h")]
public partial class UNiagaraDataInterfaceRenderTarget2D : UNiagaraDataInterfaceRWBase {
	public static UClass StaticClass() {return default;}
	///<summary>Size</summary>
	public FIntPoint Size;
	///<summary>Controls if and when we generate mips for the render target.</summary>
	public ENiagaraMipMapGeneration MipMapGeneration;
	///<summary>MipMapGenerationType</summary>
	public ENiagaraMipMapGenerationType MipMapGenerationType;
	///<summary>When enabled overrides the format of the render target, otherwise uses the project default setting.</summary>
	public ETextureRenderTargetFormat OverrideRenderTargetFormat;
	///<summary>When enabled overrides the filter of the render target, otherwise uses the project default setting.</summary>
	public TextureFilter OverrideRenderTargetFilter;
	///<summary>When enabled texture parameters (size / etc) are taken from the user provided render target.</summary>
	public bool bInheritUserParameterSettings;
	///<summary>bOverrideFormat</summary>
	public bool bOverrideFormat;
	///<summary>bPreviewRenderTarget</summary>
	public bool bPreviewRenderTarget;
	///<summary>When valid the user parameter is used as the render target rather than creating one internal, note that the input render target will be adjusted by the Niagara simulation</summary>
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	///<summary>ManagedRenderTargets</summary>
	public TMap<ulong,UTextureRenderTarget2D> ManagedRenderTargets;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceGrid2DCollection.h")]
public partial class UNiagaraDataInterfaceGrid2DCollection : UNiagaraDataInterfaceGrid2D {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to a user parameter if we&#39;re reading one.</summary>
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	///<summary>When enabled overrides the format used to store data inside the grid, otherwise uses the project default setting.  Lower bit depth formats will save memory and performance at the cost of precision.</summary>
	public ENiagaraGpuBufferFormat OverrideBufferFormat;
	///<summary>bOverrideFormat</summary>
	public bool bOverrideFormat;
	///<summary>bPreviewGrid</summary>
	public bool bPreviewGrid;
	///<summary>When enabled allows you to preview the grid in a debug display</summary>
	public FName PreviewAttribute;
	///<summary>Fills a texture render target 2d with the current data from the simulation</summary>
	public virtual bool FillTexture2D(UNiagaraComponent Component,UTextureRenderTarget2D dest,int AttributeIndex) { return default; }
	///<summary>FillRawTexture2D</summary>
	public virtual bool FillRawTexture2D(UNiagaraComponent Component,UTextureRenderTarget2D Dest,int TilesX,int TilesY) { return default; }
	///<summary>GetRawTextureSize</summary>
	public virtual void GetRawTextureSize(UNiagaraComponent Component,int SizeX,int SizeY) {}
	///<summary>GetTextureSize</summary>
	public virtual void GetTextureSize(UNiagaraComponent Component,int SizeX,int SizeY) {}
	///<summary>ManagedRenderTargets</summary>
	public TMap<ulong,UTextureRenderTarget2DArray> ManagedRenderTargets;
}

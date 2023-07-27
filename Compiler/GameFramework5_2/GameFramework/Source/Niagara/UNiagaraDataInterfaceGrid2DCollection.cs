#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceGrid2DCollection.h")]
public partial class UNiagaraDataInterfaceGrid2DCollection : UNiagaraDataInterfaceGrid2D {
// NiagaraDataInterfaceGrid2DCollection
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public ENiagaraGpuBufferFormat OverrideBufferFormat;
	public bool bOverrideFormat;
	public bool bPreviewGrid;
	public string PreviewAttribute;
	public  bool FillTexture2D(UNiagaraComponent Component,UTextureRenderTarget2D dest,int AttributeIndex) { return default; }
	public  bool FillRawTexture2D(UNiagaraComponent Component,UTextureRenderTarget2D Dest,int TilesX,int TilesY) { return default; }
	public  void GetRawTextureSize(UNiagaraComponent Component,int SizeX,int SizeY) {}
	public  void GetTextureSize(UNiagaraComponent Component,int SizeX,int SizeY) {}
	public TMap<ulong,UTextureRenderTarget2DArray> ManagedRenderTargets;
}

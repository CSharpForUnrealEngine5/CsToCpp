#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceGrid3DCollection.h")]
public partial class UNiagaraDataInterfaceGrid3DCollection : UNiagaraDataInterfaceGrid3D {
// NiagaraDataInterfaceGrid3DCollection
	public int NumAttributes;
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	public ENiagaraGpuBufferFormat OverrideBufferFormat;
	public bool bOverrideFormat;
	public bool bPreviewGrid;
	public string PreviewAttribute;
	public bool FillVolumeTexture(UObject Component,UObject dest,int AttributeIndex) { return default; }
	public bool FillRawVolumeTexture(UObject Component,UObject Dest,int TilesX,int TilesY,int TileZ) { return default; }
	public void GetRawTextureSize(UObject Component,int SizeX,int SizeY,int SizeZ) {}
	public void GetTextureSize(UObject Component,int SizeX,int SizeY,int SizeZ) {}
}

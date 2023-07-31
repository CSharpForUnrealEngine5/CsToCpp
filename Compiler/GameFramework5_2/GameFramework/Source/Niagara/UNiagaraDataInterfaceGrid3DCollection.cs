#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceGrid3DCollection.h")]
public partial class UNiagaraDataInterfaceGrid3DCollection : UNiagaraDataInterfaceGrid3D {
	///<summary>Number of attributes stored on the grid</summary>
	public int NumAttributes;
	///<summary>Reference to a user parameter if we&#39;re reading one.</summary>
	public FNiagaraUserParameterBinding RenderTargetUserParameter;
	///<summary>When enabled overrides the format used to store data inside the grid, otherwise uses the project default setting.  Lower bit depth formats will save memory and performance at the cost of precision.</summary>
	public ENiagaraGpuBufferFormat OverrideBufferFormat;
	///<summary>bOverrideFormat</summary>
	public bool bOverrideFormat;
	///<summary>bPreviewGrid</summary>
	public bool bPreviewGrid;
	///<summary>When enabled allows you to preview the grid in a debug display</summary>
	public string PreviewAttribute;
	///<summary>Fills a texture render target 2d with the current data from the simulation</summary>
	public  bool FillVolumeTexture(UNiagaraComponent Component,UVolumeTexture dest,int AttributeIndex) { return default; }
	///<summary>FillRawVolumeTexture</summary>
	public  bool FillRawVolumeTexture(UNiagaraComponent Component,UVolumeTexture Dest,int TilesX,int TilesY,int TileZ) { return default; }
	///<summary>GetRawTextureSize</summary>
	public  void GetRawTextureSize(UNiagaraComponent Component,int SizeX,int SizeY,int SizeZ) {}
	///<summary>GetTextureSize</summary>
	public  void GetTextureSize(UNiagaraComponent Component,int SizeX,int SizeY,int SizeZ) {}
}

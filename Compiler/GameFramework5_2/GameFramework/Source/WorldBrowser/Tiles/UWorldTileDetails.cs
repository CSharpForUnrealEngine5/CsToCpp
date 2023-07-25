#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tiles/WorldTileDetails.h")]
///<summary>UWorldTileDetails</summary>
public partial class UWorldTileDetails : UObject {
// WorldTileDetails
	public bool bTileEditable;
	public string PackageName;
	public string ParentPackageName;
	public FIntVector Position;
	public FIntVector AbsolutePosition;
	public int ZOrder;
	public bool bHideInTileView;
	public int NumLOD;
	public FTileLODEntryDetails LOD1;
	public FTileLODEntryDetails LOD2;
	public FTileLODEntryDetails LOD3;
	public FTileLODEntryDetails LOD4;
}

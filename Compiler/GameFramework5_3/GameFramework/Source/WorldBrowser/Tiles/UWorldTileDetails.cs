namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UWorldTileDetails</summary>
[CppInclude("Tiles/WorldTileDetails.h")]
public partial class UWorldTileDetails : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether this tile properties can be edited via details panel</summary>
	public bool bTileEditable;
	///<summary>Tile long package name (readonly)</summary>
	public FName PackageName;
	///<summary>Parent tile long package name</summary>
	public FName ParentPackageName;
	///<summary>Tile position in the world, relative to parent</summary>
	public FIntVector Position;
	///<summary>Tile absolute position in the world (readonly)</summary>
	public FIntVector AbsolutePosition;
	///<summary>Tile sorting order</summary>
	public int ZOrder;
	///<summary>Whether to hide tile in the world composition tile view</summary>
	public bool bHideInTileView;
	///<summary>LOD entries number</summary>
	public int NumLOD;
	///<summary>LOD1</summary>
	public FTileLODEntryDetails LOD1;
	///<summary>LOD2</summary>
	public FTileLODEntryDetails LOD2;
	///<summary>LOD3</summary>
	public FTileLODEntryDetails LOD3;
	///<summary>LOD4</summary>
	public FTileLODEntryDetails LOD4;
}

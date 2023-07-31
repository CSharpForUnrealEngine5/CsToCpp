#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>WorldComposition represents world structure:</summary>
[CppInclude("Engine/WorldComposition.h")]
public partial class UWorldComposition : UObject {
	///<summary>Streaming level objects for each tile</summary>
	public TArray<ULevelStreaming> TilesStreaming;
	///<summary>Time threshold between tile streaming state changes</summary>
	public double TilesStreamingTimeThreshold;
	///<summary>Whether all distance dependent tiles should be loaded and visible during cinematic</summary>
	public bool bLoadAllTilesDuringCinematic;
	///<summary>Whether to rebase origin in 3D space, otherwise only on XY plane</summary>
	public bool bRebaseOriginIn3DSpace;
	///<summary>Whether all tiles locations are locked</summary>
	public bool bLockTilesLocation;
	///<summary>Maximum distance to current view point where we should initiate origin rebasing</summary>
	public float RebaseOriginDistance;
}

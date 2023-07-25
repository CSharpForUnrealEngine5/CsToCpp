#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/WorldComposition.h")]
///<summary>WorldComposition represents world structure:</summary>
public partial class UWorldComposition : UObject {
// WorldComposition
	public TArray<ULevelStreaming> TilesStreaming;
	public double TilesStreamingTimeThreshold;
	public bool bLoadAllTilesDuringCinematic;
	public bool bRebaseOriginIn3DSpace;
	public bool bLockTilesLocation;
	public float RebaseOriginDistance;
}

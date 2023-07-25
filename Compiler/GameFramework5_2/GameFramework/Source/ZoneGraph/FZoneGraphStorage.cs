#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphStorage {
// ZoneGraphStorage
	public TArray<FZoneData> Zones;
	public TArray<FZoneLaneData> Lanes;
	public TArray<FVector> BoundaryPoints;
	public TArray<FVector> LanePoints;
	public TArray<FVector> LaneUpVectors;
	public TArray<FVector> LaneTangentVectors;
	public TArray<float> LanePointProgressions;
	public TArray<FZoneLaneLinkData> LaneLinks;
	public FBox Bounds;
	public FZoneGraphBVTree ZoneBVTree;
}

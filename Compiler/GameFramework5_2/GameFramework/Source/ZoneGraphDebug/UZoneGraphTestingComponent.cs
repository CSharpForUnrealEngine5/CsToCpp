#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTestingActor.h")]
///<summary>Actor for testing ZoneGraph functionality.</summary>
public partial class UZoneGraphTestingComponent : UPrimitiveComponent {
// ZoneGraphTestingComponent
	public  void EnableCustomTests() {}
	public  void DisableCustomTests() {}
	public UZoneGraphSubsystem ZoneGraph;
	public FZoneGraphLaneLocation LaneLocation;
	public FZoneGraphLaneLocation NextLaneLocation;
	public FZoneGraphLaneLocation NearestLaneLocation;
	public FVector SearchExtent;
	public float AdvanceDistance;
	public FVector NearestTestOffset;
	public FZoneGraphTagFilter QueryFilter;
	public bool bDrawLinkedLanes;
	public bool bDrawLaneTangentVectors;
	public bool bDrawLaneSmoothing;
	public bool bDrawBVTreeQuery;
	public bool bDrawLanePath;
	public AZoneGraphTestingActor OtherActor;
	public TArray<UZoneLaneTest> CustomTests;
}

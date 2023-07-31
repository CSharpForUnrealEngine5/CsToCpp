#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor for testing ZoneGraph functionality.</summary>
[CppInclude("ZoneGraphTestingActor.h")]
public partial class UZoneGraphTestingComponent : UPrimitiveComponent {
	///<summary>Allow custom tests to be notified when lane location is updated.</summary>
	public  void EnableCustomTests() {}
	///<summary>Prevent custom tests to be notified when lane location is updated. Currently active tests will get notified with an invalid location.</summary>
	public  void DisableCustomTests() {}
	///<summary>ZoneGraph</summary>
	public UZoneGraphSubsystem ZoneGraph;
	///<summary>LaneLocation</summary>
	public FZoneGraphLaneLocation LaneLocation;
	///<summary>NextLaneLocation</summary>
	public FZoneGraphLaneLocation NextLaneLocation;
	///<summary>NearestLaneLocation</summary>
	public FZoneGraphLaneLocation NearestLaneLocation;
	///<summary>SearchExtent</summary>
	public FVector SearchExtent;
	///<summary>AdvanceDistance</summary>
	public float AdvanceDistance;
	///<summary>NearestTestOffset</summary>
	public FVector NearestTestOffset;
	///<summary>QueryFilter</summary>
	public FZoneGraphTagFilter QueryFilter;
	///<summary>bDrawLinkedLanes</summary>
	public bool bDrawLinkedLanes;
	///<summary>bDrawLaneTangentVectors</summary>
	public bool bDrawLaneTangentVectors;
	///<summary>bDrawLaneSmoothing</summary>
	public bool bDrawLaneSmoothing;
	///<summary>bDrawBVTreeQuery</summary>
	public bool bDrawBVTreeQuery;
	///<summary>Experimental</summary>
	public bool bDrawLanePath;
	///<summary>OtherActor</summary>
	public AZoneGraphTestingActor OtherActor;
	///<summary>CustomTests</summary>
	public TArray<UZoneLaneTest> CustomTests;
}

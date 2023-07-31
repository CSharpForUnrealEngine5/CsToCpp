#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per ZoneGraphData smart object look up data.</summary>
[CppInclude("SmartObjectZoneAnnotations.h")]
public partial struct FSmartObjectAnnotationData {
	public FZoneGraphDataHandle DataHandle;
	public TArray<int> AffectedLanes;
	public TArray<FSmartObjectLaneLocation> SmartObjectLaneLocations;
	public TMap<FSmartObjectHandle,int> SmartObjectToLaneLocationIndexLookup;
	public TMap<int,FSmartObjectLaneLocationIndices> LaneToLaneLocationIndicesLookup;
}

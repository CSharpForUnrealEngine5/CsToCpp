#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectZoneAnnotations.h")]
///<summary>Per ZoneGraphData smart object look up data.</summary>
public partial struct FSmartObjectAnnotationData {
// SmartObjectAnnotationData
	public FZoneGraphDataHandle DataHandle;
	public TArray<int> AffectedLanes;
	public TArray<FSmartObjectLaneLocation> SmartObjectLaneLocations;
	public TMap<FSmartObjectHandle,int> SmartObjectToLaneLocationIndexLookup;
	public TMap<int,FSmartObjectLaneLocationIndices> LaneToLaneLocationIndicesLookup;
}

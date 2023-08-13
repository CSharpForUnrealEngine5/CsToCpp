namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>To replicate path following make a member variable of this class in your FReplicatedAgentBase derived class. In the FReplicatedAgentBase derived class you must also provide an accessor function</summary>
[CppInclude("MassReplicationPathHandlers.h")]
public partial struct FReplicatedAgentPathData {
	public FZoneGraphShortPathRequest PathRequest;
	public FZoneGraphLaneHandle LaneHandle;
	public double ActionServerStartTime;
	public float DistanceAlongLane;
	public float LaneLength;
	public FMassInt16Real DesiredSpeed;
	public ushort ActionID;
	public EMassMovementAction Action;
}

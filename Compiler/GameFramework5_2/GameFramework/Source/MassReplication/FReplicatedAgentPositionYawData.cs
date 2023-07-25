#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassReplicationTransformHandlers.h")]
///<summary>To replicate position and yaw make a member variable of this class in your FReplicatedAgentBase derived class. In the FReplicatedAgentBase derived class you must also provide an accessor function</summary>
public partial struct FReplicatedAgentPositionYawData {
// ReplicatedAgentPositionYawData
	public FVector Position;
	public float Yaw;
}

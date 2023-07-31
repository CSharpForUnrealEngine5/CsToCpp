#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>To replicate position and yaw make a member variable of this class in your FReplicatedAgentBase derived class. In the FReplicatedAgentBase derived class you must also provide an accessor function</summary>
[CppInclude("MassReplicationTransformHandlers.h")]
public partial struct FReplicatedAgentPositionYawData {
	public FVector Position;
	public float Yaw;
}

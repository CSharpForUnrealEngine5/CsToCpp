#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdReplicatedAgent.h")]
///<summary>The data that is replicated specific to each Crowd agent</summary>
public partial struct FReplicatedCrowdAgent {
// ReplicatedCrowdAgent
	public FReplicatedAgentPathData Path;
	public FReplicatedAgentPositionYawData PositionYaw;
}

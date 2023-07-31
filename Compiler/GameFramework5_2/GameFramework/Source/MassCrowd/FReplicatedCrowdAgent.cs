#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The data that is replicated specific to each Crowd agent</summary>
[CppInclude("MassCrowdReplicatedAgent.h")]
public partial struct FReplicatedCrowdAgent {
	public FReplicatedAgentPathData Path;
	public FReplicatedAgentPositionYawData PositionYaw;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The data that is replicated specific to each Crowd agent</summary>
[CppInclude("MassCrowdReplicatedAgent.h")]
public partial struct FReplicatedCrowdAgent {
	public FReplicatedAgentPathData Path;
	public FReplicatedAgentPositionYawData PositionYaw;
}

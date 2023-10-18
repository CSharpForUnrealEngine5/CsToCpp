namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fast array item for efficient agent replication. Remember to make this dirty if any FReplicatedCrowdAgent member variables are modified</summary>
[CppInclude("MassCrowdReplicatedAgent.h")]
public partial struct FCrowdFastArrayItem {
	public FReplicatedCrowdAgent Agent;
}

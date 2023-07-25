#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionComponent.h")]
///<summary>UNetworkPredictionComponent</summary>
public partial class UNetworkPredictionComponent : UActorComponent {
// NetworkPredictionComponent
	public void ServerReceiveClientInput(FServerReplicationRPCParameter ProxyParameter) {}
	public FNetworkPredictionProxy NetworkPredictionProxy;
	public FReplicationProxy ReplicationProxy_ServerRPC;
	public FReplicationProxy ReplicationProxy_Autonomous;
	public FReplicationProxy ReplicationProxy_Simulated;
	public FReplicationProxy ReplicationProxy_Replay;
}

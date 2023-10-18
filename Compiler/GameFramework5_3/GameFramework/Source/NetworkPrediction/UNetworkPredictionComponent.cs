namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UNetworkPredictionComponent</summary>
[CppInclude("NetworkPredictionComponent.h")]
public partial class UNetworkPredictionComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The actual ServerRPC. This needs to be a UFUNCTION but is generic and not dependent on the simulation instance</summary>
	public void ServerReceiveClientInput(FServerReplicationRPCParameter ProxyParameter) {}
	///<summary>Proxy to interface with the NetworkPrediction system</summary>
	public FNetworkPredictionProxy NetworkPredictionProxy;
	///<summary>ReplicationProxies are just pointers to the data/NetSerialize functions within the NetworkSim</summary>
	public FReplicationProxy ReplicationProxy_ServerRPC;
	///<summary>ReplicationProxy_Autonomous</summary>
	public FReplicationProxy ReplicationProxy_Autonomous;
	///<summary>ReplicationProxy_Simulated</summary>
	public FReplicationProxy ReplicationProxy_Simulated;
	///<summary>ReplicationProxy_Replay</summary>
	public FReplicationProxy ReplicationProxy_Replay;
}

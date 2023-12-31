namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UNetworkPredictionPhysicsComponent</summary>
[CppInclude("NetworkPredictionPhysicsComponent.h")]
public partial class UNetworkPredictionPhysicsComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Proxy to interface with the NetworkPrediction system</summary>
	public FNetworkPredictionProxy NetworkPredictionProxy;
	///<summary>UpdatedPrimitive</summary>
	public UPrimitiveComponent UpdatedPrimitive;
	///<summary>ReplicationProxy</summary>
	public FReplicationProxy ReplicationProxy;
}

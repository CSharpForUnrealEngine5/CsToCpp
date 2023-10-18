namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Network physics component that will be attached to any player controller</summary>
[CppInclude("Physics/NetworkPhysicsComponent.h")]
public partial class UNetworkPhysicsComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Server RPC to receive inputs from client</summary>
	public void ServerReceiveInputsDatas(TArray<byte> ClientInputs) {}
	///<summary>repnotify for the inputs on the client</summary>
	public void OnRep_SetReplicatedInputs() {}
	///<summary>repnotify for the states on the client</summary>
	public void OnRep_SetReplicatedStates() {}
	///<summary>replicated physics inputs</summary>
	public TArray<byte> ReplicatedInputs;
	///<summary>replicated physics states</summary>
	public TArray<byte> ReplicatedStates;
}

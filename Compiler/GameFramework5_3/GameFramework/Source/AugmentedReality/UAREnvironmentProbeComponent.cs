namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial class UAREnvironmentProbeComponent : UARComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Event when native representation is first added, called on server and clients.</summary>
	public void ReceiveAdd(FAREnvironmentProbeUpdatePayload Payload) {}
	///<summary>Event when native representation is updated, called on server and clients.</summary>
	public void ReceiveUpdate(FAREnvironmentProbeUpdatePayload Payload) {}
	///<summary>ServerUpdatePayload</summary>
	public void ServerUpdatePayload(FAREnvironmentProbeUpdatePayload NewPayload) {}
	///<summary>ReplicatedPayload</summary>
	public FAREnvironmentProbeUpdatePayload ReplicatedPayload;
}

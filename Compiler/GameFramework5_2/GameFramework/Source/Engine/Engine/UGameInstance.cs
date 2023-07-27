#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/GameInstance.h")]
///<summary>GameInstance: high-level manager object for an instance of the running game.</summary>
public partial class UGameInstance : UObject {
// GameInstance
	public TArray<ULocalPlayer> LocalPlayers;
	public UOnlineSession OnlineSession;
	public TArray<UObject> ReferencedObjects;
	public FOnPawnControllerChanged OnPawnControllerChangedDelegates;
	public  void ReceiveInit() {}
	public  void ReceiveShutdown() {}
	public FOnUserInputDeviceConnectionChange OnInputDeviceConnectionChange;
	public FOnUserInputDevicePairingChange OnUserInputDevicePairingChange;
	public  void HandleNetworkError(ENetworkFailure FailureType,bool bIsServer) {}
	public  void HandleTravelError(ETravelFailure FailureType) {}
	public  void DebugCreatePlayer(int ControllerId) {}
	public  void DebugRemovePlayer(int ControllerId) {}
}

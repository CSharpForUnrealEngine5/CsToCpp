namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GameInstance: high-level manager object for an instance of the running game.</summary>
[CppInclude("Engine/GameInstance.h")]
public partial class UGameInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of locally participating players in this game instance</summary>
	public TArray<ULocalPlayer> LocalPlayers;
	///<summary>Class to manage online services</summary>
	public UOnlineSession OnlineSession;
	///<summary>List of objects that are being kept alive by this game instance. Stored as array for fast iteration, should not be modified every frame</summary>
	public TArray<UObject> ReferencedObjects;
	///<summary>gets triggered shortly after a pawn&#39;s controller is set. Most of the time</summary>
	public FOnPawnControllerChanged OnPawnControllerChangedDelegates;
	///<summary>Opportunity for blueprints to handle the game instance being initialized.</summary>
	public void ReceiveInit() {}
	///<summary>Opportunity for blueprints to handle the game instance being shutdown.</summary>
	public void ReceiveShutdown() {}
	///<summary>Callback for when an input device connection state has changed (a new gamepad was connected or disconnected)</summary>
	public FOnUserInputDeviceConnectionChange OnInputDeviceConnectionChange;
	///<summary>Callback when an input device has changed pairings (the owning platform user has changed for that device)</summary>
	public FOnUserInputDevicePairingChange OnUserInputDevicePairingChange;
	///<summary>Opportunity for blueprints to handle network errors.</summary>
	public void HandleNetworkError(ENetworkFailure FailureType,bool bIsServer) {}
	///<summary>Opportunity for blueprints to handle travel errors.</summary>
	public void HandleTravelError(ETravelFailure FailureType) {}
	///<summary>Debug console command to create a player.</summary>
	public virtual void DebugCreatePlayer(int ControllerId) {}
	///<summary>Debug console command to remove the player with a given controller ID.</summary>
	public virtual void DebugRemovePlayer(int ControllerId) {}
}

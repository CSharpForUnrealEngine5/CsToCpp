namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cheat Manager is a central blueprint to implement test and debug code and actions that are not to ship with the game.</summary>
[CppInclude("GameFramework/CheatManager.h")]
public partial class UCheatManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Debug camera - used to have independent camera without stopping gameplay</summary>
	public ADebugCameraController DebugCameraControllerRef;
	///<summary>Debug camera - used to have independent camera without stopping gameplay</summary>
	public UClass DebugCameraControllerClass;
	///<summary>Pause the game for Delay seconds.</summary>
	public virtual void FreezeFrame(float Delay) {}
	///<summary>Teleport to surface player is looking at.</summary>
	public virtual void Teleport() {}
	///<summary>Scale the player&#39;s size to be F * default size.</summary>
	public virtual void ChangeSize(float F) {}
	///<summary>Pawn can fly.</summary>
	public virtual void Fly() {}
	///<summary>Return to walking movement mode from Fly or Ghost cheat.</summary>
	public virtual void Walk() {}
	///<summary>Pawn no longer collides with the world, and can fly</summary>
	public virtual void Ghost() {}
	///<summary>Invulnerability cheat.</summary>
	public virtual void God() {}
	///<summary>Modify time dilation to change apparent speed of passage of time. e.g. &quot;Slomo 0.1&quot; makes everything move very slowly, while &quot;Slomo 10&quot; makes everything move very fast.</summary>
	public virtual void Slomo(float NewTimeDilation) {}
	///<summary>Damage the actor you&#39;re looking at (sourced from the player).</summary>
	public virtual void DamageTarget(float DamageAmount) {}
	///<summary>Destroy the actor you&#39;re looking at.</summary>
	public virtual void DestroyTarget() {}
	///<summary>Destroy all actors of class aClass</summary>
	public virtual void DestroyAll(UClass aClass) {}
	///<summary>Destroy all pawns except for the (pawn) target.  If no (pawn) target is found we don&#39;t destroy anything.</summary>
	public virtual void DestroyAllPawnsExceptTarget() {}
	///<summary>Destroys (by calling destroy directly) all non-player pawns of class aClass in the level</summary>
	public virtual void DestroyPawns(UClass aClass) {}
	///<summary>Load Classname and spawn an actor of that class</summary>
	public virtual void Summon(string ClassName) {}
	///<summary>Freeze everything in the level except for players.</summary>
	public virtual void PlayersOnly() {}
	///<summary>Make controlled pawn the viewtarget again.</summary>
	public virtual void ViewSelf() {}
	///<summary>View from the point of view of player with PlayerName S.</summary>
	public virtual void ViewPlayer(string S) {}
	///<summary>View from the point of view of AActor with Name ActorName.</summary>
	public virtual void ViewActor(FName ActorName) {}
	///<summary>View from the point of view of an AActor of class DesiredClass.  Each subsequent ViewClass cycles through the list of actors of that class.</summary>
	public virtual void ViewClass(UClass DesiredClass) {}
	///<summary>Stream in the given level.</summary>
	public virtual void StreamLevelIn(FName PackageName) {}
	///<summary>Load the given level.</summary>
	public virtual void OnlyLoadLevel(FName PackageName) {}
	///<summary>Stream out the given level.</summary>
	public virtual void StreamLevelOut(FName PackageName) {}
	///<summary>Toggle between debug camera/player camera without locking gameplay and with locking local player controller input.</summary>
	public virtual void ToggleDebugCamera() {}
	///<summary>toggles AI logging</summary>
	public virtual void ToggleAILogging() {}
	///<summary>ServerToggleAILogging</summary>
	public virtual void ServerToggleAILogging() {}
	///<summary>Toggle capsule trace debugging. Will trace a capsule from current view point and show where it hits the world</summary>
	public virtual void DebugCapsuleSweep() {}
	///<summary>Change Trace capsule size *</summary>
	public virtual void DebugCapsuleSweepSize(float HalfHeight,float Radius) {}
	///<summary>Change Trace Channel *</summary>
	public virtual void DebugCapsuleSweepChannel(ECollisionChannel Channel) {}
	///<summary>Change Trace Complex setting *</summary>
	public virtual void DebugCapsuleSweepComplex(bool bTraceComplex) {}
	///<summary>Capture current trace and add to persistent list *</summary>
	public virtual void DebugCapsuleSweepCapture() {}
	///<summary>Capture current local PC&#39;s pawn&#39;s location and add to persistent list *</summary>
	public virtual void DebugCapsuleSweepPawn() {}
	///<summary>Clear persistent list for trace capture *</summary>
	public virtual void DebugCapsuleSweepClear() {}
	///<summary>Test all volumes in the world to the player controller&#39;s view location*</summary>
	public virtual void TestCollisionDistance() {}
	///<summary>Dump online session information</summary>
	public virtual void DumpOnlineSessionState() {}
	///<summary>Dump known party information</summary>
	public virtual void DumpPartyState() {}
	///<summary>Dump known chat information</summary>
	public virtual void DumpChatState() {}
	///<summary>Dump current state of voice chat</summary>
	public virtual void DumpVoiceMutingState() {}
	///<summary>This will move the player and set their rotation to the passed in values.</summary>
	public virtual void BugItGo(float X,float Y,float Z,float Pitch,float Yaw,float Roll) {}
	///<summary>This function is used to print out the BugIt location.  It prints out copy and paste versions for both IMing someone to type in</summary>
	public virtual void BugIt(string ScreenShotDescription/*=TEXT("")*/) {}
	///<summary>This will create a BugItGo string for us.  Nice for calling form c++ where you just want the string and no Screenshots *</summary>
	public virtual void BugItStringCreator(FVector ViewLocation,FRotator ViewRotation,string GoString,string LocString) {}
	///<summary>This will force a flush of the output log to file</summary>
	public virtual void FlushLog() {}
	///<summary>Logs the current location in bugit format without taking screenshot and further routing.</summary>
	public virtual void LogLoc() {}
	///<summary>Translate world origin to this player position</summary>
	public void SetWorldOrigin() {}
	///<summary>Exec function to return the mouse sensitivity to its default value</summary>
	public virtual void SetMouseSensitivityToDefault() {}
	///<summary>Backwards compatibility exec function for people used to it instead of using InvertAxisKey</summary>
	public virtual void InvertMouse() {}
	///<summary>Executes commands listed in CheatScript.ScriptName ini section of DefaultGame.ini</summary>
	public void CheatScript(string ScriptName) {}
	///<summary>SpawnServerStatReplicator</summary>
	public void SpawnServerStatReplicator() {}
	///<summary>DestroyServerStatReplicator</summary>
	public void DestroyServerStatReplicator() {}
	///<summary>ToggleServerStatReplicatorClientOverwrite</summary>
	public void ToggleServerStatReplicatorClientOverwrite() {}
	///<summary>ToggleServerStatReplicatorUpdateStatNet</summary>
	public void ToggleServerStatReplicatorUpdateStatNet() {}
	///<summary>UpdateSafeArea</summary>
	public void UpdateSafeArea() {}
	///<summary>OnPlayerEndPlayed</summary>
	public void OnPlayerEndPlayed(AActor Player,EEndPlayReason EndPlayReason) {}
	///<summary>BP implementable event for when CheatManager is created to allow any needed initialization.</summary>
	public void ReceiveInitCheatManager() {}
	///<summary>This is the End Play event for the CheatManager</summary>
	public void ReceiveEndPlay() {}
	///<summary>List of registered cheat manager extensions</summary>
	public TArray<UCheatManagerExtension> CheatManagerExtensions;
	///<summary>Switch controller to debug camera without locking gameplay and with locking local player controller input</summary>
	public virtual void EnableDebugCamera() {}
	///<summary>Switch controller from debug camera back to normal controller</summary>
	public virtual void DisableDebugCamera() {}
	///<summary>GetPlayerController</summary>
	public APlayerController GetPlayerController() { return default; }
}

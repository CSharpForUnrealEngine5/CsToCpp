#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/CheatManager.h")]
///<summary>Cheat Manager is a central blueprint to implement test and debug code and actions that are not to ship with the game.</summary>
public partial class UCheatManager : UObject {
// CheatManager
	public ADebugCameraController DebugCameraControllerRef;
	public UClass DebugCameraControllerClass;
	public  void FreezeFrame(float Delay) {}
	public  void Teleport() {}
	public  void ChangeSize(float F) {}
	public  void Fly() {}
	public  void Walk() {}
	public  void Ghost() {}
	public  void God() {}
	public  void Slomo(float NewTimeDilation) {}
	public  void DamageTarget(float DamageAmount) {}
	public  void DestroyTarget() {}
	public  void DestroyAll(UClass aClass) {}
	public  void DestroyAllPawnsExceptTarget() {}
	public  void DestroyPawns(UClass aClass) {}
	public  void Summon(string ClassName) {}
	public  void PlayersOnly() {}
	public  void ViewSelf() {}
	public  void ViewPlayer(string S) {}
	public  void ViewActor(string ActorName) {}
	public  void ViewClass(UClass DesiredClass) {}
	public  void StreamLevelIn(string PackageName) {}
	public  void OnlyLoadLevel(string PackageName) {}
	public  void StreamLevelOut(string PackageName) {}
	public  void ToggleDebugCamera() {}
	public  void ToggleAILogging() {}
	public  void ServerToggleAILogging() {}
	public  void DebugCapsuleSweep() {}
	public  void DebugCapsuleSweepSize(float HalfHeight,float Radius) {}
	public  void DebugCapsuleSweepChannel(ECollisionChannel Channel) {}
	public  void DebugCapsuleSweepComplex(bool bTraceComplex) {}
	public  void DebugCapsuleSweepCapture() {}
	public  void DebugCapsuleSweepPawn() {}
	public  void DebugCapsuleSweepClear() {}
	public  void TestCollisionDistance() {}
	public  void DumpOnlineSessionState() {}
	public  void DumpPartyState() {}
	public  void DumpChatState() {}
	public  void DumpVoiceMutingState() {}
	public  void BugItGo(float X,float Y,float Z,float Pitch,float Yaw,float Roll) {}
	public  void BugIt(string ScreenShotDescription/*=TEXT("")*/) {}
	public  void BugItStringCreator(FVector ViewLocation,FRotator ViewRotation,string GoString,string LocString) {}
	public  void FlushLog() {}
	public  void LogLoc() {}
	public  void SetWorldOrigin() {}
	public  void SetMouseSensitivityToDefault() {}
	public  void InvertMouse() {}
	public  void CheatScript(string ScriptName) {}
	public  void SpawnServerStatReplicator() {}
	public  void DestroyServerStatReplicator() {}
	public  void ToggleServerStatReplicatorClientOverwrite() {}
	public  void ToggleServerStatReplicatorUpdateStatNet() {}
	public  void UpdateSafeArea() {}
	public  void OnPlayerEndPlayed(AActor Player,EEndPlayReason EndPlayReason) {}
	public  void ReceiveInitCheatManager() {}
	public  void ReceiveEndPlay() {}
	public TArray<UCheatManagerExtension> CheatManagerExtensions;
	public  void EnableDebugCamera() {}
	public  void DisableDebugCamera() {}
	public  APlayerController GetPlayerController() { return default; }
}

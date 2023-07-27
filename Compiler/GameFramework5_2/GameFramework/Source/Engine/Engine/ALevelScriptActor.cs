#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/LevelScriptActor.h")]
///<summary>ALevelScriptActor is the base class for classes generated by</summary>
public partial class ALevelScriptActor : AActor {
// LevelScriptActor
	public  bool RemoteEvent(string EventName) { return default; }
	public  void SetCinematicMode(bool bCinematicMode,bool bHidePlayer/*=true*/,bool bAffectsHUD/*=true*/,bool bAffectsMovement/*=false*/,bool bAffectsTurning/*=false*/) {}
	public  void LevelReset() {}
	public  void WorldOriginLocationChanged(FIntVector OldOriginLocation,FIntVector NewOriginLocation) {}
	public bool bInputEnabled;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ALevelScriptActor is the base class for classes generated by</summary>
[CppInclude("Engine/LevelScriptActor.h")]
public partial class ALevelScriptActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Tries to find an event named &quot;EventName&quot; on all other levels, and calls it</summary>
	public  bool RemoteEvent(string EventName) { return default; }
	///<summary>Sets the cinematic mode on all PlayerControllers</summary>
	public  void SetCinematicMode(bool bCinematicMode,bool bHidePlayer/*=true*/,bool bAffectsHUD/*=true*/,bool bAffectsMovement/*=false*/,bool bAffectsTurning/*=false*/) {}
	///<summary>@todo document</summary>
	public  void LevelReset() {}
	///<summary>Event called on world origin location changes</summary>
	public  void WorldOriginLocationChanged(FIntVector OldOriginLocation,FIntVector NewOriginLocation) {}
	///<summary>bInputEnabled</summary>
	public bool bInputEnabled;
}

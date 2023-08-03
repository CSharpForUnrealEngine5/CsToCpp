#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeVREditorMode.h")]
public partial class UXRCreativeVREditorMode : UVREditorModeBase {
	public static UClass StaticClass() {return default;}
	///<summary>GetRoomTransform</summary>
	public  FTransform GetRoomTransform() { return default; }
	///<summary>GetHeadTransform</summary>
	public  FTransform GetHeadTransform() { return default; }
	///<summary>BP_OnEnter</summary>
	public  void BP_OnEnter() {}
	///<summary>BP_OnExit</summary>
	public  void BP_OnExit() {}
	///<summary>BP_Tick</summary>
	public  void BP_Tick(float DeltaSeconds) {}
	///<summary>SetRoomTransform</summary>
	public  void SetRoomTransform(FTransform RoomToWorld) {}
	///<summary>SetHeadTransform</summary>
	public  void SetHeadTransform(FTransform HeadToWorld) {}
	///<summary>MappableInputConfig</summary>
	public FSoftObjectPath MappableInputConfig;
	///<summary>ToolsetClass</summary>
	public TSoftObjectPtr<UXRCreativeToolset> ToolsetClass;
	///<summary>Avatar</summary>
	public AXRCreativeAvatar Avatar;
}

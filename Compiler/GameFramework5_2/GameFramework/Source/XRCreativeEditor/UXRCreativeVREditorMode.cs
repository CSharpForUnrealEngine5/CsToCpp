#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeVREditorMode.h")]
public partial class UXRCreativeVREditorMode : UVREditorModeBase {
// XRCreativeVREditorMode
	public FTransform GetRoomTransform() { return default; }
	public FTransform GetHeadTransform() { return default; }
	public void BP_OnEnter() {}
	public void BP_OnExit() {}
	public void BP_Tick(float DeltaSeconds) {}
	public void SetRoomTransform(FTransform RoomToWorld) {}
	public void SetHeadTransform(FTransform HeadToWorld) {}
	public FSoftObjectPath MappableInputConfig;
	public TSoftObjectPtr<UXRCreativeToolset> ToolsetClass;
	public AXRCreativeAvatar Avatar;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPScoutingSubsystem.h")]
///<summary>* Subsystem used for VR Scouting</summary>
public partial class UVPScoutingSubsystem : UEditorSubsystem {
// VPScoutingSubsystem
	public UVPScoutingSubsystemHelpersBase VPSubsystemHelpers;
	public UVPScoutingSubsystemGestureManagerBase GestureManager;
	public bool IsSettingsMenuOpen;
	public float GripNavSpeedCoeff;
	public void ToggleVRScoutingUI(FVREditorFloatingUICreationContext CreationContext) {}
	public void HideInfoDisplayPanel() {}
	public bool IsVRScoutingUIOpen(string PanelID) { return default; }
	public UObject GetPanelActor(string PanelID) { return default; }
	public UObject GetPanelWidget(string PanelID) { return default; }
	public TArray<UObject> GetActiveEditorVRControllers() { return default; }
	public string GetVProdPanelID(EVProdPanelIDs Panel) { return default; }
	public string GetDirectorName() { return default; }
	public string GetShowName() { return default; }
	public bool IsUsingMetricSystem() { return default; }
	public void SetIsUsingMetricSystem(bool bInUseMetricSystem) {}
	public bool IsUsingTransformGizmo() { return default; }
	public void SetIsUsingTransformGizmo(bool bInIsUsingTransformGizmo) {}
	public void SetShowTransformGizmoCVar(bool bInShowTransformGizmoCVar) {}
	public float GetFlightSpeed() { return default; }
	public void SetFlightSpeed(float InFlightSpeed) {}
	public float GetGripNavSpeed() { return default; }
	public void SetGripNavSpeed(float InGripNavSpeed) {}
	public bool IsUsingInertiaDamping() { return default; }
	public void SetIsUsingInertiaDamping(bool bInIsUsingInertiaDamping) {}
	public void SetInertiaDampingCVar(float InInertiaDamping) {}
	public bool IsHelperSystemEnabled() { return default; }
	public void SetIsHelperSystemEnabled(bool bInIsHelperSystemEnabled) {}
	public UObject GetVREditorMode() { return default; }
	public bool EnterVRMode() { return default; }
	public void ExitVRMode() {}
	public bool IsLocationGridSnappingEnabled() { return default; }
	public void ToggleLocationGridSnapping() {}
	public bool IsRotationGridSnappingEnabled() { return default; }
	public void ToggleRotationGridSnapping() {}
}

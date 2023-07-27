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
	public  void ToggleVRScoutingUI(FVREditorFloatingUICreationContext CreationContext) {}
	public  void HideInfoDisplayPanel() {}
	public  bool IsVRScoutingUIOpen(string PanelID) { return default; }
	public  AVREditorFloatingUI GetPanelActor(string PanelID) { return default; }
	public  UUserWidget GetPanelWidget(string PanelID) { return default; }
	public static TArray<UVREditorInteractor> GetActiveEditorVRControllers() { return default; }
	public static string GetVProdPanelID(EVProdPanelIDs Panel) { return default; }
	public static string GetDirectorName() { return default; }
	public static string GetShowName() { return default; }
	public static bool IsUsingMetricSystem() { return default; }
	public static void SetIsUsingMetricSystem(bool bInUseMetricSystem) {}
	public static bool IsUsingTransformGizmo() { return default; }
	public static void SetIsUsingTransformGizmo(bool bInIsUsingTransformGizmo) {}
	public static void SetShowTransformGizmoCVar(bool bInShowTransformGizmoCVar) {}
	public static float GetFlightSpeed() { return default; }
	public static void SetFlightSpeed(float InFlightSpeed) {}
	public static float GetGripNavSpeed() { return default; }
	public static void SetGripNavSpeed(float InGripNavSpeed) {}
	public static bool IsUsingInertiaDamping() { return default; }
	public static void SetIsUsingInertiaDamping(bool bInIsUsingInertiaDamping) {}
	public static void SetInertiaDampingCVar(float InInertiaDamping) {}
	public static bool IsHelperSystemEnabled() { return default; }
	public static void SetIsHelperSystemEnabled(bool bInIsHelperSystemEnabled) {}
	public static UVREditorMode GetVREditorMode() { return default; }
	public static bool EnterVRMode() { return default; }
	public static void ExitVRMode() {}
	public static bool IsLocationGridSnappingEnabled() { return default; }
	public static void ToggleLocationGridSnapping() {}
	public static bool IsRotationGridSnappingEnabled() { return default; }
	public static void ToggleRotationGridSnapping() {}
}

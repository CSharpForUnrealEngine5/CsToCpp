#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Subsystem used for VR Scouting</summary>
[CppInclude("VPScoutingSubsystem.h")]
public partial class UVPScoutingSubsystem : UEditorSubsystem {
	///<summary>Subsystems can&#39;t have any Blueprint implementations, so we attach this class for any BP logic that we to provide.</summary>
	public UVPScoutingSubsystemHelpersBase VPSubsystemHelpers;
	///<summary>GestureManager that manage some user input in VR editor.</summary>
	public UVPScoutingSubsystemGestureManagerBase GestureManager;
	///<summary>bool to keep track of whether the settings menu panel in the main menu is open</summary>
	public bool IsSettingsMenuOpen;
	///<summary>This is a multiplier for grip nav speed so we can keep the grip nav value in the range 0-1 and increase this variable if we need a bigger range</summary>
	public float GripNavSpeedCoeff;
	///<summary>Open a widget UI in front of the user. Opens default VProd UI (defined via the &#39;Virtual Scouting User Interface&#39; setting) if null.</summary>
	public  void ToggleVRScoutingUI(FVREditorFloatingUICreationContext CreationContext) {}
	///<summary>Hide VR Sequencer Window</summary>
	public  void HideInfoDisplayPanel() {}
	///<summary>Check whether a widget UI is open</summary>
	public  bool IsVRScoutingUIOpen(string PanelID) { return default; }
	///<summary>Get UI panel Actor from the passed ID</summary>
	public  AVREditorFloatingUI GetPanelActor(string PanelID) { return default; }
	///<summary>Get UI panel widget from the passed ID</summary>
	public  UUserWidget GetPanelWidget(string PanelID) { return default; }
	///<summary>GetActiveEditorVRControllers</summary>
	public static TArray<UVREditorInteractor> GetActiveEditorVRControllers() { return default; }
	///<summary>GetVProdPanelID</summary>
	public static string GetVProdPanelID(EVProdPanelIDs Panel) { return default; }
	///<summary>GetDirectorName</summary>
	public static string GetDirectorName() { return default; }
	///<summary>GetShowName</summary>
	public static string GetShowName() { return default; }
	///<summary>Whether the VR user wants to use the metric system instead of imperial</summary>
	public static bool IsUsingMetricSystem() { return default; }
	///<summary>Set whether the VR user wants to use the metric system instead of imperial</summary>
	public static void SetIsUsingMetricSystem(bool bInUseMetricSystem) {}
	///<summary>Whether the VR user wants to have the transform gizmo enabled</summary>
	public static bool IsUsingTransformGizmo() { return default; }
	///<summary>Set whether the VR user wants to have the transform gizmo enabled</summary>
	public static void SetIsUsingTransformGizmo(bool bInIsUsingTransformGizmo) {}
	///<summary>Set value of cvar &quot;VI.ShowTransformGizmo&quot;</summary>
	public static void SetShowTransformGizmoCVar(bool bInShowTransformGizmoCVar) {}
	///<summary>Get flight speed for scouting in VR</summary>
	public static float GetFlightSpeed() { return default; }
	///<summary>Set flight speed for scouting in VR</summary>
	public static void SetFlightSpeed(float InFlightSpeed) {}
	///<summary>Get grip nav speed for scouting in VR</summary>
	public static float GetGripNavSpeed() { return default; }
	///<summary>Set grip nav speed for scouting in VR</summary>
	public static void SetGripNavSpeed(float InGripNavSpeed) {}
	///<summary>Whether grip nav inertia is enabled when scouting in VR</summary>
	public static bool IsUsingInertiaDamping() { return default; }
	///<summary>Set whether grip nav inertia is enabled when scouting in VR</summary>
	public static void SetIsUsingInertiaDamping(bool bInIsUsingInertiaDamping) {}
	///<summary>Set value of cvar &quot;VI.HighSpeedInertiaDamping&quot;</summary>
	public static void SetInertiaDampingCVar(float InInertiaDamping) {}
	///<summary>Whether the helper system on the controllers is enabled</summary>
	public static bool IsHelperSystemEnabled() { return default; }
	///<summary>Set whether the helper system on the controllers is enabled</summary>
	public static void SetIsHelperSystemEnabled(bool bInIsHelperSystemEnabled) {}
	///<summary>Get VR Editor Mode object</summary>
	public static UVREditorMode GetVREditorMode() { return default; }
	///<summary>Enter VR Mode</summary>
	public static bool EnterVRMode() { return default; }
	///<summary>Exit VR Mode</summary>
	public static void ExitVRMode() {}
	///<summary>Whether location grid snapping is enabled</summary>
	public static bool IsLocationGridSnappingEnabled() { return default; }
	///<summary>Toggle location grid snapping</summary>
	public static void ToggleLocationGridSnapping() {}
	///<summary>Whether rotation grid snapping is enabled</summary>
	public static bool IsRotationGridSnappingEnabled() { return default; }
	///<summary>Toggle rotation grid snapping</summary>
	public static void ToggleRotationGridSnapping() {}
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Virtual Production utilities settings for editor</summary>
[CppInclude("VPUtilitiesEditorSettings.h")]
public partial class UVPUtilitiesEditorSettings : UObject {
	///<summary>The default user interface that we&#39;ll use for virtual scouting</summary>
	public TSoftObjectPtr<UClass> VirtualScoutingUI;
	///<summary>Speed when flying in VR</summary>
	public float FlightSpeed;
	///<summary>Speed when using grip nav in VR</summary>
	public float GripNavSpeed;
	///<summary>Whether to use the metric system or imperial for measurements</summary>
	public bool bUseMetric;
	///<summary>Whether to enable or disable the transform gizmo</summary>
	public bool bUseTransformGizmo;
	///<summary>If true, the user will use inertia damping to stop after grip nav. Otherwise the user will just stop immediately</summary>
	public bool bUseGripInertiaDamping;
	///<summary>Damping applied to inertia</summary>
	public float InertiaDamping;
	///<summary>Whether the helper system on the controllers is enabled</summary>
	public bool bIsHelperSystemEnabled;
	///<summary>When enabled, an OSC server will automatically start on launch.</summary>
	public bool bStartOSCServerAtLaunch;
	///<summary>The OSC server&#39;s address.</summary>
	public string OSCServerAddress;
	///<summary>The OSC server&#39;s port.</summary>
	public ushort OSCServerPort;
	///<summary>What EditorUtilityObject should be ran on editor launch.</summary>
	public TArray<FSoftObjectPath> StartupOSCListeners;
	///<summary>ScoutingSubsystem class to use for Blueprint helpers</summary>
	public FSoftClassPath ScoutingSubsystemEditorUtilityClassPath;
	///<summary>GestureManager class to use by the ScoutingSubsystem</summary>
	public FSoftClassPath GestureManagerEditorUtilityClassPath;
	///<summary>GestureManager class to use by the ScoutingSubsystem</summary>
	public TArray<FSoftClassPath> AdditionnalClassToLoad;
	///<summary>VPSplinePreviewMeshPath</summary>
	public FSoftObjectPath VPSplinePreviewMeshPath;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPUtilitiesEditorSettings.h")]
///<summary>Virtual Production utilities settings for editor</summary>
public partial class UVPUtilitiesEditorSettings : UObject {
// VPUtilitiesEditorSettings
	public TSoftObjectPtr<UClass> VirtualScoutingUI;
	public float FlightSpeed;
	public float GripNavSpeed;
	public bool bUseMetric;
	public bool bUseTransformGizmo;
	public bool bUseGripInertiaDamping;
	public float InertiaDamping;
	public bool bIsHelperSystemEnabled;
	public bool bStartOSCServerAtLaunch;
	public string OSCServerAddress;
	public ushort OSCServerPort;
	public TArray<FSoftObjectPath> StartupOSCListeners;
	public FSoftClassPath ScoutingSubsystemEditorUtilityClassPath;
	public FSoftClassPath GestureManagerEditorUtilityClassPath;
	public TArray<FSoftClassPath> AdditionnalClassToLoad;
	public FSoftObjectPath VPSplinePreviewMeshPath;
}

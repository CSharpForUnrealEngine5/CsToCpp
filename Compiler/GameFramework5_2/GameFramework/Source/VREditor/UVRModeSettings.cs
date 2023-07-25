#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VRModeSettings.h")]
///<summary>Implements the settings for VR Mode.</summary>
public partial class UVRModeSettings : UVISettings {
// VRModeSettings
	public bool bEnableAutoVREditMode;
	public bool bAutokeySequences;
	public EInteractorHand InteractorHand;
	public bool bShowWorldMovementGrid;
	public bool bShowWorldMovementPostProcess;
	public bool bShowWorldScaleProgressBar;
	public float UIBrightness;
	public float GizmoScale;
	public float DoubleClickTime;
	public float TriggerPressedThreshold_Vive;
	public float TriggerPressedThreshold_Rift;
	public TSoftObjectPtr<UClass> InteractorClass;
	public TSoftObjectPtr<UClass> TeleporterClass;
	public TSoftObjectPtr<UClass> ModeClass;
}

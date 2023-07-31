#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for VR Mode.</summary>
[CppInclude("VRModeSettings.h")]
public partial class UVRModeSettings : UVISettings {
	///<summary>If true, wearing a Vive or Oculus Rift headset will automatically enter VR Editing mode</summary>
	public bool bEnableAutoVREditMode;
	///<summary>Whether or not sequences should be autokeyed</summary>
	public bool bAutokeySequences;
	///<summary>Which hand should have the primary interactor laser on it</summary>
	public EInteractorHand InteractorHand;
	///<summary>Show the movement grid for orientation while moving through the world</summary>
	public bool bShowWorldMovementGrid;
	///<summary>Dim the surroundings while moving through the world</summary>
	public bool bShowWorldMovementPostProcess;
	///<summary>Display a progress bar while scaling that shows your current scale</summary>
	public bool bShowWorldScaleProgressBar;
	///<summary>Adjusts the brightness of the UI panels</summary>
	public float UIBrightness;
	///<summary>The size of the transform gizmo</summary>
	public float GizmoScale;
	///<summary>The maximum time in seconds between two clicks for a double-click to register</summary>
	public float DoubleClickTime;
	///<summary>The amount (between 0-1) you have to depress the Vive controller trigger to register a press</summary>
	public float TriggerPressedThreshold_Vive;
	///<summary>The amount (between 0-1) you have to depress the Oculus Touch controller trigger to register a press</summary>
	public float TriggerPressedThreshold_Rift;
	///<summary>InteractorClass</summary>
	public TSoftObjectPtr<UClass> InteractorClass;
	///<summary>TeleporterClass</summary>
	public TSoftObjectPtr<UClass> TeleporterClass;
	///<summary>The mode extension to use when UnrealEd is in VR mode. Use VREditorMode to get default editor behavior or select a custom mode.</summary>
	public TSoftObjectPtr<UClass> ModeClass;
}

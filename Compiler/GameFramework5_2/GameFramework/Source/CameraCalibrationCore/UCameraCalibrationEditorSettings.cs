#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the camera calibration when in editor and standalone.</summary>
[CppInclude("CameraCalibrationSettings.h")]
public partial class UCameraCalibrationEditorSettings : UDeveloperSettings {
	///<summary>True if a lens file button shortcut should be added to level editor toolbar.</summary>
	public bool bShowEditorToolbarButton;
	///<summary>Data Table category color settings</summary>
	public FLensDataCategoryEditorColor CategoryColor;
	///<summary>Enable or Disable Time input driven by evaluation inputs.</summary>
	public bool bEnableTimeSlider;
	///<summary>Units used to display/interpret Focal Length and Image Center</summary>
	public ELensDisplayUnit DefaultDisplayUnit;
	///<summary>If true, the media player in the calibration tools will always use the default step rate.</summary>
	public bool bForceDefaultMediaStepRate;
	///<summary>The default step rate (ms) that the media player in the calibration tools should use when stepping forward/back</summary>
	public float DefaultMediaStepRateInMilliseconds;
	///<summary>Startup lens file per user in editor</summary>
	public TSoftObjectPtr<ULensFile> UserLensFile;
}

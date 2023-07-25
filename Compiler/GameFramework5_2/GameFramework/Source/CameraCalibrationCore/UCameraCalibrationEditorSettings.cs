#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraCalibrationSettings.h")]
///<summary>Settings for the camera calibration when in editor and standalone.</summary>
public partial class UCameraCalibrationEditorSettings : UDeveloperSettings {
// CameraCalibrationEditorSettings
	public bool bShowEditorToolbarButton;
	public FLensDataCategoryEditorColor CategoryColor;
	public bool bEnableTimeSlider;
	public ELensDisplayUnit DefaultDisplayUnit;
	public bool bForceDefaultMediaStepRate;
	public float DefaultMediaStepRateInMilliseconds;
	public TSoftObjectPtr<ULensFile> UserLensFile;
}

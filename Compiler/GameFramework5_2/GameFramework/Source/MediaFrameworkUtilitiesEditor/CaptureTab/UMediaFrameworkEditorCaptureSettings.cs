#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the capture that are persistent per users.</summary>
[CppInclude("CaptureTab/SMediaFrameworkCapture.h")]
public partial class UMediaFrameworkEditorCaptureSettings : UMediaFrameworkWorldSettingsAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>Should the Capture setting be saved with the level or should it be saved as a project settings.</summary>
	public bool bSaveCaptureSetingsInWorld;
	///<summary>Should the capture be restarted if the media output is modified.</summary>
	public bool bAutoRestartCaptureOnChange;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the OpenXR Input plugin.</summary>
[CppInclude("OpenXRHandTrackingSettings.h")]
public partial class UOpenXRHandTrackingSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If false (the default) the motion sources for hand tracking will be of the form &#39;[Left|Right][Keypoint]&#39;.  If true they will be of the form &#39;HandTracking[Left|Right][Keypoint]&#39;.  True is reccomended to avoid collisions between motion sources from different device types. *</summary>
	public bool bUseMoreSpecificMotionSourceNames;
	///<summary>If true hand tracking supports the &#39;Left&#39; and &#39;Right&#39; legacy motion sources.  If false it does not.  False is reccomended unless you need legacy compatibility in an older unreal projects.*</summary>
	public bool bSupportLegacyControllerMotionSources;
}

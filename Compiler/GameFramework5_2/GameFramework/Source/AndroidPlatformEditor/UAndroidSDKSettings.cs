#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidSDKSettings.h")]
///<summary>Implements the settings for the Android SDK setup.</summary>
public partial class UAndroidSDKSettings : UObject {
// AndroidSDKSettings
	public FDirectoryPath SDKPath;
	public FDirectoryPath NDKPath;
	public FDirectoryPath JavaPath;
	public string SDKAPILevel;
	public string NDKAPILevel;
}

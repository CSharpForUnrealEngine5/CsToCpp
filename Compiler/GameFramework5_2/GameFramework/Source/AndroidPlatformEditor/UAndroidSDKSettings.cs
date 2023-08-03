#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Android SDK setup.</summary>
[CppInclude("AndroidSDKSettings.h")]
public partial class UAndroidSDKSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Location on disk of the Android SDK (falls back to ANDROID_HOME environment variable if this is left blank)</summary>
	public FDirectoryPath SDKPath;
	///<summary>Location on disk of the Android NDK (falls back to NDKROOT environment variable if this is left blank)</summary>
	public FDirectoryPath NDKPath;
	///<summary>Location on disk of Java (falls back to JAVA_HOME environment variable if this is left blank)</summary>
	public FDirectoryPath JavaPath;
	///<summary>Which SDK to package and compile Java with (a specific version or (without quotes) &#39;latest&#39; for latest version on disk, or &#39;matchndk&#39; to match the NDK API Level)</summary>
	public string SDKAPILevel;
	///<summary>Which NDK to compile with (a specific version or (without quotes) &#39;latest&#39; for latest version on disk). Note that choosing android-21 or later won&#39;t run on pre-5.0 devices.</summary>
	public string NDKAPILevel;
}

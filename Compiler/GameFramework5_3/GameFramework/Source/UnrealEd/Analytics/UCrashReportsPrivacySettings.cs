namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Analytics/CrashReportsPrivacySettings.h")]
public partial class UCrashReportsPrivacySettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Determines whether the editor automatically sends some bug reports Epic Games in order to improve Unreal Engine. Your information will never be shared with 3rd parties.</summary>
	public bool bSendUnattendedBugReports;
}

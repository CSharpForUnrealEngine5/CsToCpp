#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreTypes.h")]
///<summary>@defgroup GoogleARCoreBase Google ARCore Base</summary>
public enum EGoogleARCoreAvailability {
	UnknownError=0,
	UnknownChecking=1,
	UnknownTimedOut=2,
	UnsupportedDeviceNotCapable=100,
	SupportedNotInstalled=201,
	SupportedApkTooOld=202,
	SupportedInstalled=203,
}

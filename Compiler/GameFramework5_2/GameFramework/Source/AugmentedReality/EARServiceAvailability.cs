#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARDependencyHandler.h")]
public enum EARServiceAvailability {
	UnknownError=0,
	UnknownChecking=1,
	UnknownTimedOut=2,
	UnsupportedDeviceNotCapable=3,
	SupportedNotInstalled=4,
	SupportedVersionTooOld=5,
	SupportedInstalled=6,
}

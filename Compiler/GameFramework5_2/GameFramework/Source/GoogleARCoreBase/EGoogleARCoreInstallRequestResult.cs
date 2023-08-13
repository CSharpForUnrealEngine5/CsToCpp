namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreTypes.h")]
public enum EGoogleARCoreInstallRequestResult {
	Installed=0,
	DeviceNotCompatible=1,
	UserDeclinedInstallation=2,
	FatalError=3,
}

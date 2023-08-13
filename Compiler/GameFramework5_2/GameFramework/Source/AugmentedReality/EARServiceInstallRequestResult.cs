namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARDependencyHandler.h")]
public enum EARServiceInstallRequestResult {
	Installed=0,
	DeviceNotCompatible=1,
	UserDeclinedInstallation=2,
	FatalError=3,
}

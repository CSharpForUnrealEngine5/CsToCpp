#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARDependencyHandler.h")]
public enum EARServiceInstallRequestResult {
	Installed=0,
	DeviceNotCompatible=1,
	UserDeclinedInstallation=2,
	FatalError=3,
}
